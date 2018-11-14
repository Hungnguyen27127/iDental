using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
    public class MedicalRecord
    {
        public int MedicalRecordID { get; set; }
        public int PatientID { get; set; }
        public string Diagnostic { get; set; } 
        public DateTime DateOfCreate { get; set; }
        public int EmployeeID { get; set; }    
    }
}
