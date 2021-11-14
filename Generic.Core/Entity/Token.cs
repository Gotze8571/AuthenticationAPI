using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Core.Entity
{
    public class Token
    {
        public Guid TokenID { get; set; }
        public string TokenType { get; set; }
        public DateTime Token_Date_Created { get; set; }
        public int TokenNumber { get; set; }
    }
}
