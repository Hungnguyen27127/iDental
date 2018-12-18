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
    public class MedicineDetailController : ApiController
    {
        ServiceDetailDAO dao = new ServiceDetailDAO();

        public IHttpActionResult PostChiTietDichVu([FromBody] MedicineDetail DT)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (dao.Post_DonThuoc(DT) == false)
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }

    }
}
