using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models.DTOs.Requests
{
    public class TokenRequest
    {
        [Required]
        public string token { get; set; }
        [Required]
        public string refreshToken { get; set; }
    }
}
