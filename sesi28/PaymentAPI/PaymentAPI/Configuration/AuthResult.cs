using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Configuration
{
    public class AuthResult
    {
        public string token { get; set; }
        public string refreshToken { get; set; }
        public bool success { get; set; }
        public List<string> errors { get; set; }

    }
}
