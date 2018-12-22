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

        public ShortenPatient GetShortenPatient(int patientID)
        {
            const string proc = "SP_TimBenhNhanTheoID";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("PATIENTID", patientID)
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            ShortenPatient res = new ShortenPatient();
            ShortenPatient lichhen;
            while (reader.Read())
            {
                lichhen = new ShortenPatient();
                lichhen.PatientID = Convert.ToInt32(reader["PatientID"]);
                lichhen.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                lichhen.PatientName = Convert.ToString(reader["PatientName"]);
                lichhen.Gender = Convert.ToString(reader["Gender"]);
                res = lichhen;
            }
            return res;
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

        public List<Patient> SearchBenhNhan2(string Patientname) // Tìm Kiếm Bệnh Nhân theo tên 
        {
            string query = $"select * from PATIENT where PatientName LIKE N'%{Patientname}%'";
            List<Patient> res = new List<Patient>();
            IDataReader reader = DataProvider.ExecuteReaderQuery(query);

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
                
                res.Add(benhnhan);
            }

            return res;
        }
        //Ham Lay Du Lieu Cho Bang THuoc

        public List<Medicine> Get_Thuoc()
        {
            const string proc = "SP_XemDanhMucThuoc";
            List<SqlParameter> para = null;
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<Medicine> result = new List<Medicine>();
            Medicine thuoc;
            while (reader.Read())
            {
                thuoc = new Medicine();
                thuoc.MedicineID = Convert.ToInt32(reader["MedicineID"]);
                thuoc.MedicineName = Convert.ToString(reader["MedicineName"]);
                thuoc.Category = Convert.ToString(reader["Category"]);

                result.Add(thuoc);
            }
            return result;
        }
        public List<Medicine> Search_Thuoc(string Category) // Tìm Kiếm thuoc theo danh mục
        {
            string query = $"select * from MEDICINE where Category LIKE N'%{Category}%'";
            List<Medicine> res = new List<Medicine>();
            IDataReader reader = DataProvider.ExecuteReaderQuery(query);

            Medicine thuoc;
            while (reader.Read())
            {
                thuoc = new Medicine();
                thuoc.MedicineID = Convert.ToInt32(reader["MedicineID"]);
                thuoc.MedicineName = Convert.ToString(reader["MedicineName"]);
                thuoc.Category = Convert.ToString(reader["Category"]);
             

                res.Add(thuoc);
            }

            return res;
        }

        //Hàm Tìm Kiếm CHo Dịch Vụ 
        public List<Service> Search_DichVu(string ServiceName) // Tìm Kiếm Dv theo ten DV
        {
            string query = $"select * from SERVICE where ServiceName LIKE N'%{ServiceName}%'";
            List<Service> res = new List<Service>();
            IDataReader reader = DataProvider.ExecuteReaderQuery(query);

            Service dv;
            while (reader.Read())
            {
                dv = new Service();
                dv.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                dv.ServiceName = Convert.ToString(reader["ServiceName"]);
                dv.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                dv.Notes = Convert.ToString(reader["Notes"]);
                res.Add(dv);
            }

            return res;
        }
        //public bool Search_DichVu2(string ServiceName) // Tìm Kiếm Dv theo ten DV
        //{
        //    string query = $"delete SERVICE where ServiceName = N'{ServiceName}'";
           
        //    IDataReader res = DataProvider.ExecuteQuery(query);

        //    if (res != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
