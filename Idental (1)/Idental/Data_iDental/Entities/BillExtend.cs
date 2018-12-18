using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
    public class BillExtend
    {
        public int BillID { get; set; }
        public string PatientName { get; set; }
        public DateTime DateOfCreate { get; set; }
        public string Diagnostic { get; set; }
        public int MedicalRecordID { get; set; }


    }
}
