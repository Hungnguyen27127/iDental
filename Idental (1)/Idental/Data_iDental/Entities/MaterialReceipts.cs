using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
   public class MaterialReceipts
    {
       public int MaterialsReceiptID { get; set;  }
        public DateTime ReceiptDate { get; set; }
        public int MaterialID { get; set; }
        public int ReceiptAmount { get; set; }
        public int EmployeeID { get; set; }
    }
}
