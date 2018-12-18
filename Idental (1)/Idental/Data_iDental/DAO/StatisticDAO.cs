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
    public class StatisticDAO
    {
        public List<Statistic> GetTK(DateTime date1, DateTime date2)
        {
            const string proc = "SP_DembenhNhan1Ngay";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("dateofcreate1", date1),
                new SqlParameter("dateofcreate2", date2)

            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<Statistic> result = new List<Statistic>();
            Statistic tk;
            while (reader.Read())
            {
                tk = new Statistic();
                tk.DateOfCreate = Convert.ToDateTime(reader["DateOfCreate"]);
                tk.PatientNumber = Convert.ToInt32(reader["PatientNumber"]);
                result.Add(tk);
            }
            return result;
        }
        public List<NumberOfPatient> GetNOP()
        {
            const string proc = "SP_XemBenhNhanTheoBacSy";
            List<SqlParameter> para = new List<SqlParameter>()
            {

            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<NumberOfPatient> result = new List<NumberOfPatient>();
            NumberOfPatient tk;
            while (reader.Read())
            {
                tk = new NumberOfPatient();
                tk.EmployeeName = Convert.ToString(reader["EmployeeName"]);
                tk.PatientNumber = Convert.ToInt32(reader["PatientNumber"]);
                result.Add(tk);
            }
            return result;
        }
        public List<TKService> GetTKService()
        {
            const string proc = "SP_XemSoLanSuDungDichVu";
            List<SqlParameter> para = new List<SqlParameter>()
            {

            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<TKService> result = new List<TKService>();
            TKService tk;
            while (reader.Read())
            {
                tk = new TKService();
                tk.ServiceName = Convert.ToString(reader["ServiceName"]);
                tk.NumberOfuse = Convert.ToInt32(reader["NumberOfuse"]);
                result.Add(tk);
            }
            return result;
        }
    }
}
