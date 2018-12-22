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
   public class AccountDAO
    {
        public int Login(string username, string password)
        {
            const string proc = "SP_DangNhap";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("Username", username),
                new SqlParameter("Password", password)
            };

            int res = (int)DataProvider.ExecuteScalar(proc, para);

            return res;
        }

        public string TenHienThi(string Username)
        {
            const string proc = "SP_TenHienThi";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("Username", Username)
            };

            string res = (string)DataProvider.ExecuteScalar(proc, para);

            return res;
        }
        public Account GETlogin(string username)
        {
            const string proc = "DangNhap";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("ACCOUNTNAME", username)

            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            Account res = new Account();
            while (reader.Read())
            {
                res.Password = Convert.ToString(reader["Password"]);
                res.AccountID = Convert.ToInt32(reader["AccountID"]);
                res.AccountName = Convert.ToString(reader["AccountName"]);
                res.Role = Convert.ToString(reader["Role"]);
            }
            return res;

        }

        public EmployeeShorten GETlinfor(int accountID)
        {
            const string proc = "HienThiNguoiDangNhap";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("ACCOUNTID", accountID)

            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            EmployeeShorten res = new EmployeeShorten();
            while (reader.Read())
            {
                res.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                res.EmployeeName = Convert.ToString(reader["EmployeeName"]);              
                res.Position = Convert.ToString(reader["Position"]);              
            }
            return res;

        }
    }
}
