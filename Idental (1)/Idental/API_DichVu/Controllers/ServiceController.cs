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
    public class ServiceController : ApiController
    {
        ServiceDAO dao = new ServiceDAO();
        public IHttpActionResult GetDV()//
        {
            List<Service> list = dao.GetDichVu();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }

        public IHttpActionResult Get_TheoID(int serviceID)
        {
            Service res = dao.SearchService(serviceID);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        } 

        public IHttpActionResult PostDichVu([FromBody] Service dv)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (dao.PostDichVu(dv) == false)
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }

        public IHttpActionResult PutDichVu([FromBody] Service dv)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.PutDichVu(dv))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
        public IHttpActionResult DeleteDichVu(int ServiceID)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.DeleteDichVu(ServiceID))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
    }
}
