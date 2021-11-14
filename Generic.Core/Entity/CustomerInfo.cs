using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Core.Entity
{
    public class CustomerInfo
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Cust_ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Cust_Address1 { get; set; }
        public string Cust_Address2 { get; set; }
        public string Phone_Number1 { get; set; }
        public string Phone_Number2 { get; set; }
        public string Email_Address { get; set; }
        [Required]
        public string Customer_Image { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public DateTime Created_Date { get; set; }
        //public string Status { get; set; }

    }
}
