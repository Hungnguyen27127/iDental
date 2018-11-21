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
    }
}
