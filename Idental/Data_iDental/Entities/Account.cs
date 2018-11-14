using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
   public class Account
    {
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
