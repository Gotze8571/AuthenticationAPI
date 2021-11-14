using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Core.DTOs
{
    public class TokenDto
    {
        [Key]
        public Guid TokenID { get; set; }
        public string TokenType { get; set; }
        public string TokenKey { get; set; }
    }
}
