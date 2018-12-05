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
    public class ServiceDetailController : ApiController
    {
        ServiceDetailDAO dao = new ServiceDetailDAO();


        public IHttpActionResult PostChiTietDichVu([FromBody] ServiceDetail dv)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (dao.PostChiTietDichVu(dv) == false)
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }

    }
}
