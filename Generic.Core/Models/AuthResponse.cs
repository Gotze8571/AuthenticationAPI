using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Core.Models
{
    [Table("AuthResponses")]
    public class AuthResponse
    {
        [Key]
        public string Code { get; set; }
        public string Description { get; set; }
        public string Resolution { get; set; }
        public bool Status { get; set; }
    }

}
