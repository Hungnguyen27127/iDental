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
    public class PatientController : ApiController
    {
        PatientDAO dao = new PatientDAO();
        //AppointmentDAO test = new AppointmentDAO();
        //public IHttpActionResult GetLH()//int employeeID
        //{
        //    List<AppointmentShow> list = test.GetLichHen();
        //    if (list.Count == 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(list);
        //}

        public IHttpActionResult GetPatient()
        {
            List<Patient> list = dao.GetAllPatient();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
    }
}
