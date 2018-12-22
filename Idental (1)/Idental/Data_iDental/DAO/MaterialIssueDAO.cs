using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.DAO
{
    public class MaterialIssueDAO
    {
        public List<MaterialIssues> GetMaterialIssue()
        {
            const string proc = "SP_DSXuatVatLieu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
              
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<MaterialIssues> result = new List<MaterialIssues>();
            MaterialIssues lichhen;
            while (reader.Read())
            {
                lichhen = new MaterialIssues();
                lichhen.MaterialsID = Convert.ToInt32(reader["MaterialsID"]);
                lichhen.IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                lichhen.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                lichhen.IssueAmount = Convert.ToInt32(reader["IssueAmount"]);
                lichhen.MaterialsIssueID = Convert.ToInt32(reader["MaterialsIssueID"]);

                result.Add(lichhen);
            }

            return result;
        }

        public bool PostMaterialIssue(MaterialIssues lh)
        {
            const string proc = "XuatVatLieu";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("MATERIALID", lh.MaterialsID),
                new SqlParameter("ISSUEAMOUNT", lh.IssueAmount),
                new SqlParameter ("EMPLOYEEID" , lh.EmployeeID) ,
                new SqlParameter ("ISSUEDATE" , lh.IssueDate)
            };

            int res = DataProvider.ExecuteNonQuery(proc, para);

            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
