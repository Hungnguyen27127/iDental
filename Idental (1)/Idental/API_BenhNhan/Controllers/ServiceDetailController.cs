using Data_iDental.DAO;
using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_BenhNhan.Controllers
{
    public class ServiceDetailController : ApiController
    {
        BillDAO dao = new BillDAO();
        public IHttpActionResult PostServiceDetail([FromBody] ServiceDetail dv)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.PostServiceDetail(dv))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
    }
}
