using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
    public class Bill
    {
        public int BillID { get; set; }
    //    public float TotalBill { get; set; }
        public int ServiceID { get; set; }
        public string ServiceName { get; set; } 
        public int UnitPrice { get; set; }
        public int MedicalRecordID { get; set;}
    }
}
