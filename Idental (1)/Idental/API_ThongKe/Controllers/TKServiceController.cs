using Data_iDental.DAO;
using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_ThongKe.Controllers
{
    public class TKServiceController : ApiController
    {
        StatisticDAO dao = new StatisticDAO();
        public IHttpActionResult GetTKService()//int employeeID
        {
            List<TKService> list = dao.GetTKService();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
    }
}
