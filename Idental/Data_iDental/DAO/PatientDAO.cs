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
    public class PatientDAO
    {
        public List<Patient>GetAllPatient()
        {
            const string proc = "SP_XemBenhNhan";
            List<SqlParameter> para = null;
            IDataReader reader = DataProvider.ExecuteReader(proc, para );
            List<Patient> result = new List<Patient>();
            Patient benhnhan;
            while (reader.Read())
            {
                benhnhan = new Patient();
                benhnhan.PatientID = Convert.ToInt32(reader["PatientID"]);
                benhnhan.PatientName = Convert.ToString(reader["PatientName"]);
                benhnhan.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                benhnhan.Gender = Convert.ToString(reader["Gender"]).Trim();

                benhnhan.Address = Convert.ToString(reader["Address"]);
                benhnhan.PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                benhnhan.Image = Convert.ToString(reader["Image"]);
                result.Add(benhnhan);
            }
            return result;
        }
        public List<Patient>GetBenhNhanTheoBacSy(string employeeID)
        {
            const string proc = "SP_XemBenhNhan";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("employeeID",employeeID)
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<Patient> result = new List<Patient>();
            Patient benhnhan;
            while (reader.Read())
            {
                benhnhan = new Patient();
                benhnhan.PatientID = Convert.ToInt32(reader["MaKT"]);
                benhnhan.PatientName = Convert.ToString(reader["MaKT"]);
                benhnhan.DateOfBirth = Convert.ToDateTime(reader["MaKT"]);
                benhnhan.Gender = Convert.ToString(reader["TenLKT"]);

                benhnhan.Address = Convert.ToString(reader["TenLKT"]);
                benhnhan.PhoneNumber = Convert.ToString(reader["TenLKT"]);
                benhnhan.Image = Convert.ToString(reader["TenLKT"]);
                result.Add(benhnhan);
            }

            return result;
        }

        public bool PostBenhNhan(Patient bn)
        {
            const string proc = "SP_ThemBenhNhan";

            List<SqlParameter> para = new List<SqlParameter>()
            {               
                new SqlParameter("PATIENTNAME", bn.PatientName),
                new SqlParameter("DATEOFBIRTH", bn.DateOfBirth),
                new SqlParameter("GENDER", bn.Gender),

                new SqlParameter("ADDRESS", bn.Address),
                new SqlParameter("IMAGE", bn.Image),
                new SqlParameter("PHONENUMBER", bn.PhoneNumber),
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
        public bool PutBenhNhan(Patient bn)
        {
            const string proc = "SP_SuaBenhNhan";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("PATIENTID",bn.PatientID),
                new SqlParameter("PATIENTNAME", bn.PatientName),
                new SqlParameter("DATEOFBIRTH", bn.DateOfBirth),
                new SqlParameter("GENDER", bn.Gender),

                new SqlParameter("ADDRESS", bn.Address),
                new SqlParameter("IMAGE", bn.Image),
                new SqlParameter("PHONENUMBER", bn.PhoneNumber),
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
        public bool DeleteBenhNhan(int PatientID)
        {
            const string proc = "SP_XoaBenhNhan";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("PATIENTID", PatientID)
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
        public Patient SearchBenhNhan(string patientID) // Timf kieems benh nhan theo ma benh nhan
        {
            const string proc = "SP_TimKiemBenhNhan";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("mabn", patientID)
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            Patient res = new Patient();
            Patient benhnhan;
            while (reader.Read())
            {
                benhnhan = new Patient();

                benhnhan.PatientID = Convert.ToInt32(reader["MaKT"]);
                benhnhan.PatientName = Convert.ToString(reader["MaKT"]);
                benhnhan.DateOfBirth = Convert.ToDateTime(reader["MaKT"]);
                benhnhan.Gender = Convert.ToString(reader["TenLKT"]);

                benhnhan.Address = Convert.ToString(reader["TenLKT"]);
                benhnhan.PhoneNumber = Convert.ToString(reader["TenLKT"]);
                benhnhan.Image = Convert.ToString(reader["TenLKT"]);
                res = benhnhan;
            }
            return res;
        }
    }
}
