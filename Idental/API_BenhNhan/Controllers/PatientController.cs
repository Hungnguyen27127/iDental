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
    public class PatientController : ApiController
    {
        PatientDAO dao = new PatientDAO();
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
