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
   public class AppointmentDAO
    {
        public List<AppointmentShow> GetLichHen()
        {
            const string proc = "SP_XemLichHen";
            List<SqlParameter> para = new List<SqlParameter>()
            {
               // new SqlParameter("employeeID - 1",employeeID - 2)// 1 là ten prameter trong Proc , 2 là tên parameter của hàm
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<AppointmentShow> result = new List<AppointmentShow>();
            AppointmentShow lichhen  ;
            while (reader.Read())
            {
                lichhen = new AppointmentShow();
                lichhen.AppointmentID = Convert.ToInt32(reader["AppointmentID"]);
                lichhen.Date = Convert.ToDateTime(reader["Date"]);
                lichhen.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                lichhen.EmployeeName = Convert.ToString(reader["EmployeeName"]);
                result.Add(lichhen);
            }

            return result;
        }

        public List<AppointmentShow> GetLichHenHomeNay()
        {
            const string proc = "SP_XemLichHenHomNay";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                // new SqlParameter("employeeID - 1",employeeID - 2)// 1 là ten prameter trong Proc , 2 là tên parameter của hàm
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<AppointmentShow> result = new List<AppointmentShow>();
            AppointmentShow lichhen;
            while (reader.Read())
            {
                lichhen = new AppointmentShow();
                lichhen.AppointmentID = Convert.ToInt32(reader["AppointmentID"]);
                lichhen.Date = Convert.ToDateTime(reader["Date"]);
                lichhen.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                lichhen.EmployeeName = Convert.ToString(reader["EmployeeName"]);
                result.Add(lichhen);
            }

            return result;
        }

        public List<Doctor> LoadDataForDoctorComboBox( )
        {
            const string proc = "SP_XemDoctor";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                // new SqlParameter("employeeID - 1",employeeID - 2)// 1 là ten prameter trong Proc , 2 là tên parameter của hàm                
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<Doctor> result = new List<Doctor>();
            Doctor bs;
            while (reader.Read())
            {
                bs = new Doctor();
                bs.DoctorID = Convert.ToInt32(reader["DoctorID"]);
                bs.DoctorName = Convert.ToString(reader["DoctorName"]);
                                                       
                result.Add(bs);
            }

            return result;
        }
        public bool PostLichHen(Appointment lh)
        {
            const string proc = "SP_ThemLichHen";

            List<SqlParameter> para = new List<SqlParameter>()
            {             
                new SqlParameter("DATE", lh.Date),
                new SqlParameter("EMPLOYEEID", lh.EmployeeID),              
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
        public bool PutLichHen(Appointment lh)
        {
            const string proc = "SP_SuaLichHen";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("APPOINTMENTID",lh.AppointmentID),
                new SqlParameter("DATE", lh.Date),
                new SqlParameter("EMPLOYEEID", lh.EmployeeID),
              // new SqlParameter("KhoanThu", lh.Name),               
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
        public bool DeleteLichHen(int AppointmentID)
        {
            const string proc = "SP_XoaLichHen";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("APPOINTMENTID", AppointmentID)
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
        public Appointment SearchLichHen(int appointmentID) // Timf kieems lichj henj theo ma .
        {
            const string proc = "SP_TimKiemLichHenTheoMaNhanVien";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("APPOINTMENTID", appointmentID)
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            Appointment res = new Appointment();
            Appointment lichhen;
            while (reader.Read())
            {
                lichhen = new Appointment();
                lichhen.AppointmentID = Convert.ToInt32(reader["AppointmentID"]);
                lichhen.Date = Convert.ToDateTime(reader["Date"]);
                lichhen.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                res = lichhen;
            }
            return res;
        }
    } 
}
