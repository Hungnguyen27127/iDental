using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
    public class Material
    {
        public int MaterialID { get; set; }
        public string MaterialName { get; set; }
        public int ProviderID { get; set; }
        public int AvailableAmount { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
