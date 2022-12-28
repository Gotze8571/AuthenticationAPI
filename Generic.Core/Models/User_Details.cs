using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Core.Models
{
    public class User_Details
    {
        [Key]
        public int Id { get; set; }
        public string UserID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string UserPix { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public string Sub_Role { get; set; }
        public int count { get; set; }
        public DateTime Login_time { get; set; }
        public DateTime Created_Date { get; set; }
        
    }
}
