using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.Entities
{
    public class MaterialIssues
    {
        public int MaterialsIssueID { get; set; }
        public DateTime IssueDate { get; set; }
        public int MaterialsID { get; set; }
        public int IssueAmount { get; set; }
        public int EmployeeID { get; set; }
    }
}
