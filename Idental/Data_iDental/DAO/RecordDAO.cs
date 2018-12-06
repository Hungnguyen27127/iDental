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
    public class RecordDAO
    {
        public List<RecordShow> GetAll( )
        {
            const string proc = "SP_XemLichSuKham";
            List<SqlParameter> para = new List<SqlParameter>()
            {
             
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<RecordShow> result = new List<RecordShow>();
            RecordShow lsk;
            while (reader.Read())
            {
                lsk = new RecordShow();
                lsk.MedicalRecordID = Convert.ToInt32(reader["MedicalRecordID"]);
                lsk.PatientName = Convert.ToString(reader["PatientName"]);
                lsk.DateOfCreate = Convert.ToDateTime(reader["DateOfCreate"]);
                lsk.PaymentState = Convert.ToString(reader["PaymentState"]);

                lsk.Diagnostic = Convert.ToString(reader["Diagnostic"]);
                lsk.EmployeeName = Convert.ToString(reader["EmployeeName"]);

                result.Add(lsk);
            }
            return result;
        }
        public List<RecordShow> GetAllRecord(int PatientID)
        {
            const string proc = "SP_XemLichSuKhamTheoBenhNhan";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("PATIENTID",PatientID)
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<RecordShow> result = new List<RecordShow>();
            RecordShow lsk;
            while (reader.Read())
            {
                lsk = new RecordShow();
                lsk.MedicalRecordID = Convert.ToInt32(reader["MedicalRecordID"]);
                lsk.PatientName = Convert.ToString(reader["PatientName"]);
                lsk.DateOfCreate = Convert.ToDateTime(reader["DateOfCreate"]);
                lsk.PaymentState = Convert.ToString(reader["PaymentState"]);

                lsk.Diagnostic = Convert.ToString(reader["Diagnostic"]);
                lsk.EmployeeName = Convert.ToString(reader["EmployeeName"]);

                result.Add(lsk);
            }
            return result;
        }

        public bool PostRecord(Record bn)
        {
            const string proc = "SP_ThemMedicalRecord";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("PATIENTID", bn.PatientID),
                new SqlParameter("DATEOFCREATE", bn.DateOfCreate),
                new SqlParameter("DIAGNOSTIC", bn.Diagnostic),

                new SqlParameter("PAYMENTSTATE", bn.PaymentState),
                new SqlParameter("EMPLOYEEID", bn.EmployeeID),
              
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
       
    

        public bool PutRecord(Record bn)
        {
            const string proc = "SP_SuaMedicalRecord";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("PATIENTID", bn.PatientID),
                new SqlParameter("DATEOFCREATE", bn.DateOfCreate),
                new SqlParameter("DIAGNOSTIC", bn.Diagnostic),

                new SqlParameter("PAYMENTSTATE", bn.PaymentState),
                new SqlParameter("EMPLOYEEID", bn.EmployeeID),

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
        public bool DeleteRecord(int id)
        {
            const string proc = "SP_XoaMedicalRecord";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("MEDICALRECORDID", id)
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
