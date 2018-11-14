using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeID { get; set; }
   
    }
}