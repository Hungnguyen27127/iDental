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
   public class BillDAO
    {
        public List<Bill>GetHoaDon(int MedicalRecordID)
        {
            const string proc = "SP_XemHoaDon";
        List<SqlParameter> para = new List<SqlParameter>()
        {
            new SqlParameter("MedicalRecordID",MedicalRecordID)
            // new SqlParameter("employeeID - 1",employeeID - 2)// 1 là ten prameter trong Proc , 2 là tên parameter của hàm
        };
        IDataReader reader = DataProvider.ExecuteReader(proc, para);
        List<Bill> result = new List<Bill>();
        Bill hoadon;
            while (reader.Read())
            {
                hoadon = new Bill();
                hoadon.BillID = Convert.ToInt32(reader["BillID"]);
                hoadon.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                hoadon.ServiceName = Convert.ToString(reader["ServiceName"]);
                hoadon.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                hoadon.MedicalRecordID = Convert.ToInt32(reader["MedicalRecordID"]);
                result.Add(hoadon);
            }

            return result;
        }

        public bool PutPaymentState(Record bn)
        {
            const string proc = "SP_CapNhatTinhTrangThanhToan";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("MEDICALRECORDID", bn.MedicalRecordID),

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
        public List<BillExtend> GetBillExtend( int patientID)
        {
            const string proc = "SP_DSHoaDonMoRong";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("PATIENTID",patientID)
            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<BillExtend> result = new List<BillExtend>();
            BillExtend hd;
            while (reader.Read())
            {
                hd = new BillExtend();
                hd.BillID = Convert.ToInt32(reader["BillID"]);
                hd.PatientName = Convert.ToString(reader["PatientName"]);
                hd.DateOfCreate = Convert.ToDateTime(reader["DateOfCreate"]);
                hd.Diagnostic = Convert.ToString(reader["Diagnostic"]);
                hd.MedicalRecordID  = Convert.ToInt32(reader["MedicalRecordID"]);
                result.Add(hd);
            }
            return result;
        }

        public bool PostServiceDetail(ServiceDetail ctdv)
        {
            const string proc = "SP_ThemChiTietDichVu";

            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("SERVICEID", ctdv.ServiceID),
                new SqlParameter("BILLID", ctdv.BillID),                
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
