using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Core.Models
{
    public class ApiResponse
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public object Data { get; set; }
    }
}
