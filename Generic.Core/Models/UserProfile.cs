using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Core.Models
{
    public class UserProfile
    {
        public string UserID { get; set; }
        public Guid RequestId { get; set; }
        public byte UserPix { get; set; }
        public string Approval_Level { get; set; }
        public string User_Department { get; set; }
        public string Approval_Comment { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Approved_Date { get; set; }
    }
}
