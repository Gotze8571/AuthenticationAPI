using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Core.Models
{
    public class ErrorResponse
    {
        public List<Error> errors { get; set; }
        public Error error { get; set; }
    }
}
