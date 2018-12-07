using Data_iDental.DAO;
using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Test.Controllers
{
    public class ThongKeController : ApiController
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
    }
}
