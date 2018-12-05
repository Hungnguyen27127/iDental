using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
    public  class ServiceDetail
    {
     public int   ServiceDetailID { get; set; }
     public int ServiceID { get; set; }
     public int BillID { get; set; }
    }
}
