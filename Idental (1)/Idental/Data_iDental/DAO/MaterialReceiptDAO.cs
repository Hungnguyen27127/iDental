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
     public class MaterialReceiptDAO
    {
        public List<MaterialReceipts> GetMaterialReceipt()
        {
            const string proc = "SP_DSNhapVatLieu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                // new SqlParameter("employeeID - 1",employeeID - 2)// 1 là ten prameter trong Proc , 2 là tên parameter của hàm
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<MaterialReceipts> result = new List<MaterialReceipts>();
            MaterialReceipts lichhen;
            while (reader.Read())
            {
                lichhen = new MaterialReceipts();
                lichhen.MaterialID = Convert.ToInt32(reader["MaterialID"]);
                lichhen.ReceiptDate = Convert.ToDateTime(reader["ReceiptDate"]);
                lichhen.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                lichhen.ReceiptAmount = Convert.ToInt32(reader["ReceiptAmount"]);
                lichhen.MaterialsReceiptID = Convert.ToInt32(reader["MaterialsReceiptID"]);
               
                result.Add(lichhen);
            }

            return result;
        }

        public bool PostMaterialReceipt(MaterialReceipts lh)
        {
            const string proc = "NhapVatLieu";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("MATERIALID", lh.MaterialID),
                new SqlParameter("RECEIPTAMOUNT", lh.ReceiptAmount),
                new SqlParameter ("EMPLOYEEID" , lh.EmployeeID) ,
                new SqlParameter ("RECEIPTDATE" , lh.ReceiptDate)
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
