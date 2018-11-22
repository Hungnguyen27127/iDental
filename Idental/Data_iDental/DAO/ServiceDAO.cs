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
    public class ServiceDAO
    {
        public List<Service> GetDichVu()
        {
            const string proc = "SP_XemDichVu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                // new SqlParameter("employeeID - 1",employeeID - 2)// 1 là ten prameter trong Proc , 2 là tên parameter của hàm
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<Service> result = new List<Service>();
            Service dichvu;
            while (reader.Read())
            {
                dichvu = new Service();
                dichvu.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                dichvu.ServiceName = Convert.ToString(reader["ServiceName"]);
                dichvu.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                dichvu.Notes = Convert.ToString(reader["Notes"]);
                result.Add(dichvu);
            }

            return result;
        }
        public bool PostDichVu(Service dv)
        {

            const string proc = "SP_ThemDichVu";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("ServiceName",dv.ServiceName ),
                new SqlParameter("UnitPrice",dv.UnitPrice ),
                new SqlParameter("Notes",dv.Notes),
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
        public bool PutDichVu(Service dv)
        {
            const string proc = "SP_SuaDichVu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("ServiceID", dv.ServiceID),
                new SqlParameter("ServiceName", dv.ServiceName),
                new SqlParameter("UnitPrice", dv.UnitPrice),
                new SqlParameter("Notes", dv.Notes),
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
        public bool DeleteDichVu(int ServiceID)
        {
            const string proc = "SP_XoaDichVu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("SERVICEID", ServiceID)
            };
            int res = DataProvider.ExecuteNonQuery(proc, para);
            if (res != 0)
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
