using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Core.Models
{
    public class AuthConfig
    {
        public string baseUrl { get; set; }
        public string IpAddress { get; set; }
        public string Username { get; set; }
        public string ClientID { get; set; }
        public string SecretKey { get; set; }
    }
}
