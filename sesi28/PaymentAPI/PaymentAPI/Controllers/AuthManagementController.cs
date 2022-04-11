using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PaymentAPI.Configuration;
using PaymentAPI.Models.DTOs.Requests;
using PaymentAPI.Models.DTOs.Responses;
using PaymentAPI.Models;
using PaymentAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")] // api/authManagement
    [ApiController]
    public class AuthManagementController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtConfig;
        private readonly TokenValidationParameters _tokenValidationParams;
        private readonly ApiDbContext _apiDbContext;

        // TokenValidationParameters tokenValidationParameters,
        public AuthManagementController(
            UserManager<IdentityUser> userManager,
            IOptionsMonitor<JwtConfig> optionsMonitor,
            IOptionsMonitor<JwtBearerOptions> optionsMonitorJwtBearerOpt,
            ApiDbContext apiDbContext
        )
        {
            _userManager = userManager;
            _jwtConfig = optionsMonitor.CurrentValue;
            var jwtBearerOpt = optionsMonitorJwtBearerOpt.Get(JwtBearerDefaults.AuthenticationScheme);
            _tokenValidationParams = jwtBearerOpt.TokenValidationParameters;
            _apiDbContext = apiDbContext;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto user)
        {
            if (ModelState.IsValid)
            {
                // We can utilise the model
                var existingUser = await _userManager.FindByEmailAsync(user.email);

                if (existingUser != null)
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        errors = new List<string>() {
                            "Email is already registered."
                        },
                        success = false
                    });
                }

                var newUser = new IdentityUser() { Email = user.email, UserName = user.username };
                var isCreated = await _userManager.CreateAsync(newUser, user.password);

                if (isCreated.Succeeded)
                {
                    var jwtToken = await GenerateJwtToken(newUser);
                    return Ok(jwtToken);
                }
                else
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        errors = isCreated.Errors.Select(x => x.Description).ToList(),
                        success = false
                    });
                }
            }
            return BadRequest(new RegistrationResponse()
            {
                errors = new List<string>() {
                        "Invalid payload"
                    },
                success = false
            });
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.email);

                if (existingUser == null)
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        errors = new List<string>() {
                            "Invalid login request"
                        },
                        success = false
                    });
                }

                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.password);

                if (!isCorrect)
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        errors = new List<string>() {
                        "Invalid login request"
                    },
                        success = false
                    });
                }
                var jwtToken = await GenerateJwtToken(existingUser);

                return Ok(jwtToken);
            }
            return BadRequest(new RegistrationResponse()
            {
                errors = new List<string>() {
                    "Invalid payload"
                },
                success = false
            });
        }

        [HttpPost]
        [Route("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenRequest tokenRequest)
        {
            if (ModelState.IsValid)
            {
                var result = await VerifyAndGenerateToken(tokenRequest);

                if (result == null)
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        errors = new List<string>() {
                            "Invalid tokens"
                        },
                        success = false
                    });
                }
                return Ok(result);
            }

            return BadRequest(new RegistrationResponse()
            {
                errors = new List<string>()
                {
                    "Invalid payload"
                },
                success = false
            });
        }

        private async Task<AuthResult> GenerateJwtToken(IdentityUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            var refreshToken = new RefreshToken()
            {
                jwtId = token.Id,
                isUsed = false,
                isRevoked = false,
                userId = user.Id,
                addedDate = DateTime.UtcNow,
                expiryDate = DateTime.UtcNow.AddMinutes(30),
                token = RandomString(35) + Guid.NewGuid()
            };

            await _apiDbContext.RefreshTokens.AddAsync(refreshToken);
            _apiDbContext.SaveChanges();
            return new AuthResult()
            {
                token = jwtToken,
                success = true,
                refreshToken = refreshToken.token
            };
        }

        private async Task<AuthResult> VerifyAndGenerateToken(TokenRequest tokenRequest)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            try
            {
                // Validation 1 - Validation JWT token format
                var tokenInVerification = jwtTokenHandler.ValidateToken(tokenRequest.token, _tokenValidationParams, out var validatedToken);

                // Validation 2 - Validate encryption alg
                if (validatedToken is JwtSecurityToken jwtSecurityToken)
                {
                    var result = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase);

                    if (result == false)
                    {
                        return null;
                    }
                }
                // Validation 3 - Validate expiry date
                var utcExpiryDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp).Value);
                var expiryDate = UnixTimeStampToDateTime(utcExpiryDate);

                if (expiryDate > DateTime.UtcNow)
                {
                    return new AuthResult()
                    {
                        success = false,
                        errors = new List<string>() {
                                "Token has not yet expired"
                            }
                    };
                }

                // // Validation 4 - Validate existence of the token
                var storedToken = await _apiDbContext.RefreshTokens.FirstOrDefaultAsync(x => x.token == tokenRequest.refreshToken);

                if (storedToken == null)
                {
                    return new AuthResult()
                    {
                        success = false,
                        errors = new List<string>() {
                                "Token does not exist"
                            }
                    };
                }

                // // Validation 5 - Validate if used
                if (storedToken.isUsed)
                {
                    return new AuthResult()
                    {
                        success = false,
                        errors = new List<string>() {
                                "Token has been used"
                            }
                    };
                }

                // // Validation 6 - Validate if revoked
                if (storedToken.isRevoked)
                {
                    return new AuthResult()
                    {
                        success = false,
                        errors = new List<string>() {
                            "Token has been revoked"
                            }
                    };
                }

                // // Validatoin 7 - Validate the id
                var jti = tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value;

                if (storedToken.jwtId != jti)
                {
                    return new AuthResult()
                    {
                        success = false,
                        errors = new List<string>() {
                                "Token doesn't match"
                            }
                    };
                }

                // Update current token
                storedToken.isUsed = true;
                _apiDbContext.RefreshTokens.Update(storedToken);
                _apiDbContext.SaveChanges();

                // Generate a new token
                var dbUser = await _userManager.FindByIdAsync(storedToken.userId);
                return await GenerateJwtToken(dbUser);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Lifetime validation failed, The token is expired."))
                {
                    return new AuthResult()
                    {
                        success = false,
                        errors = new List<string>() {
                            "Token has expired please re-login"
                        }
                    };
                }
                else
                {
                    return new AuthResult()
                    {
                        success = false,
                        errors = new List<string>() {
                            "Something went wrong." + ex.Message + " " + _tokenValidationParams.IssuerSigningKey
                        }
                    };
                }
            }
        }

        private DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            var dateTimeVal = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTimeVal = dateTimeVal.AddSeconds(unixTimeStamp).ToUniversalTime();

            return dateTimeVal;
        }

        private string RandomString(int length)
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(x => x[random.Next(x.Length)]).ToArray());
        }
    }
}
