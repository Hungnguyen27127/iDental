using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Data_iDental.Entities;

namespace Data_iDental.DAO
{
    public class MedicalRecordDAO
    {
        public List<MedicalRecord> GetHoSo(string employeeID)
        {
            const string proc = "SP_XemHoSo";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("employeeID",employeeID)
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<MedicalRecord> result = new List<MedicalRecord>();
            MedicalRecord hoso;
            while (reader.Read())
            {
                hoso = new MedicalRecord();
                hoso. MedicalRecordID = Convert.ToInt32(reader["MaKT"]);
                hoso.PatientID = Convert.ToInt32(reader["MaKT"]);
                hoso.DateOfCreate = Convert.ToDateTime(reader["MaKT"]);
                hoso.EmployeeID = Convert.ToInt32(reader["MaKT"]);
                hoso.Diagnostic = Convert.ToString(reader["TenLKT"]);

                result.Add(hoso);
            }

            return result;
        }

        public bool PostHoSo(MedicalRecord hs)
        {
            const string proc = "SP_ThemHoSo";

            List<SqlParameter> para = new List<SqlParameter>()
            {
              new SqlParameter("MedicalrRecordID",hs.MedicalRecordID),
                new SqlParameter("Ngay", hs.PatientID),
                new SqlParameter("LoaiKT", hs.Diagnostic),
                new SqlParameter("KhoanThu", hs.DateOfCreate),
                new SqlParameter("KhoanThu", hs.EmployeeID),

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
        public bool PutHoSo(MedicalRecord hs)
        {
            const string proc = "SP_SuaHoSo";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("MedicalrRecordID",hs.MedicalRecordID),
                new SqlParameter("Ngay", hs.PatientID),
                new SqlParameter("LoaiKT", hs.Diagnostic),
                new SqlParameter("KhoanThu", hs.DateOfCreate),
                new SqlParameter("KhoanThu", hs.EmployeeID),
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
        public bool DeleteHoSo(int medicalrRecordID)
        {
            const string proc = "SP_XoaHoSo";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("MedicalrRecordID", medicalrRecordID)
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
