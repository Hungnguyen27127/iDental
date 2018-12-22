using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
    public class MaterialShow
    {
        public int MaterialID { get; set; }
        public string MaterialName { get; set; }
        public string ProviderName { get; set; }
        public int AvailableAmount { get; set; }
        //public DateTime ExpirationDate { get; set; }
    }
}
