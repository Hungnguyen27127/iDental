using Data_iDental.DAO;
using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_DichVu.Controllers
{
    public class MedicineController : ApiController
    {
        PatientDAO dao = new PatientDAO();

        public IHttpActionResult GetCatelogyName()
        {
            List<Medicine> list = dao.Get_Thuoc();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }

        public IHttpActionResult GetMedicine_byName(string CatelogyName)
        {
            List<Medicine> list = dao.Search_Thuoc(CatelogyName);
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
        public IHttpActionResult GetDichVu_byName(string ServiceName)
        {
            List<Service> list = dao.Search_DichVu(ServiceName);
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }

    }
}
