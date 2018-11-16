using Data_iDental.DAO;
using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_LichHen.Controllers
{
    public class LoadHomeController : ApiController
    {
        AppointmentDAO dao = new AppointmentDAO();
        public IHttpActionResult GetLHForHome()//int employeeID
        {
            List<AppointmentShow> list = dao.GetLichHenHomeNay();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
    }
}
    