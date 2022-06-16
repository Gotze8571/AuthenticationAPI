using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Core.Models
{
    public class SystemInfo
    {
        [Key]
        public int Id { get; set; }
        public string ComputerName { get; set; }
        public string ComputerNumber { get; set; }
        public DateTime ComputerModel { get; set; }
    }
}
