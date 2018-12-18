using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
   public class RecordShow
    {
       public int MedicalRecordID { get; set; }
        public string PatientName { get; set; }

        public DateTime DateOfCreate { get; set; }
        public string Diagnostic { get; set; }
        public string PaymentState { get; set; }  
        public string EmployeeName { get; set; }

        public int BillID { get; set; }
    }
}
