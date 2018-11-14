using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
   public class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
    }
}
