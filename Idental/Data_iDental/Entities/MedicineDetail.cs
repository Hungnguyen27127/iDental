using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
   public  class MedicineDetail
    {
        public int  MedicineDetailID { get; set; }
        public int  MedicineID { get; set; }
        public string Among { get; set; }
        public string Usage { get; set; }
        public int MedicalRecordID { get; set; }
    }
}
