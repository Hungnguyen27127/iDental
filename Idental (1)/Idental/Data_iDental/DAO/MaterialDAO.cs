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
    public class MaterialDAO
    {
        public List<MaterialShow> GetVatTu()
        {
            const string proc = "XemVatLieu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                // new SqlParameter("employeeID - 1",employeeID - 2)// 1 là ten prameter trong Proc , 2 là tên parameter của hàm
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<MaterialShow> result = new List<MaterialShow>();
            MaterialShow vattu;
            while (reader.Read())
            {
                vattu = new MaterialShow();
                vattu.MaterialID = Convert.ToInt32(reader["MaterialID"]);
                vattu.MaterialName = Convert.ToString(reader["MaterialName"]);
                vattu.ProviderName = Convert.ToString(reader["ProviderName"]);
                vattu.AvailableAmount = Convert.ToInt32(reader["AvailableAmount"]);
                //vattu.ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                result.Add(vattu);
            }

            return result;
        }

        public List<Provider> LoadDataForProviderComboBox()
        {
            const string proc = "SP_XemNhaCungCap";
            List<SqlParameter> para = new List<SqlParameter>()
            {
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<Provider> result = new List<Provider>();
            Provider ncc;
            while (reader.Read())
            {
                ncc = new Provider();
                ncc.ProviderID = Convert.ToInt32(reader["ProviderID"]);
                ncc.ProviderName = Convert.ToString(reader["ProviderName"]);

                result.Add(ncc);
            }

            return result;
        }

        public bool PostVatTu(Material vt)
        {
            const string proc = "ThemVatLieu";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("materialname", vt.MaterialName),
                new SqlParameter("providerid", vt.ProviderID),
                new SqlParameter("availableamount", vt.AvailableAmount),
                new SqlParameter("expirationdate", vt.ExpirationDate),
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

        public bool PutVatTu(Material vt)
        {
            const string proc = "SuaVatLieu";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("materialid",vt.MaterialID),
                new SqlParameter("materialname", vt.MaterialName),
                new SqlParameter("providerid", vt.ProviderID),
                new SqlParameter("availableamount", vt.AvailableAmount),
                new SqlParameter("expirationdate", vt.ExpirationDate),
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

        public bool DeleteVatTu(int MaterialID)
        {
            const string proc = "XoaVatLieu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("MATERIALID", MaterialID)
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
        public MaterialShow SearchVatLieu(int id)
        {
            const string proc = "SP_TimKiemVatLieuTheoMa";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("@MATERIALID", id)
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            MaterialShow res = new MaterialShow();
            MaterialShow vattu;
            while (reader.Read())
            {
                vattu = new MaterialShow();
                vattu.MaterialID = Convert.ToInt32(reader["MaterialID"]);
                vattu.MaterialName = Convert.ToString(reader["MaterialName"]);
                vattu.ProviderName = Convert.ToString(reader["ProviderName"]);
                vattu.AvailableAmount = Convert.ToInt32(reader["AvailableAmount"]);
                //vattu.ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                res = vattu;
            }
            return res;
        }
    }
}
