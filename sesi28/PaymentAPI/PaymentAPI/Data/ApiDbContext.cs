using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;
using PaymentAPI.Data;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PaymentAPI.Models.DTOs.Requests;

namespace PaymentAPI.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<UserLoginRequest> UserLogin { get; set; }

        public DbSet<UserRegistrationDto> UserRegist { get; set; }
        public DbSet<ItemData> Items { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}
