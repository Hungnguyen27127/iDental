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
    public class StatisticController : ApiController
    {
        StatisticDAO dao = new StatisticDAO();
        public IHttpActionResult GetTK(DateTime date1, DateTime date2)//int employeeID
        {
            List<Statistic> list = dao.GetTK(date1, date2);
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
        public IHttpActionResult GetTK()//int employeeID
        {
            List<NumberOfPatient> list = dao.GetNOP();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
    }
}
