using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.DAO
{
   public class ServiceDetailDAO
    {
        public bool PostChiTietDichVu(ServiceDetail ct)
        {

            const string proc = "SP_ThemChiTietDichVu";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("DETAILID",ct.ServiceDetailID ),
                new SqlParameter("SERVICEID",ct.ServiceID ),
                new SqlParameter("BILLID",ct.BillID),
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
