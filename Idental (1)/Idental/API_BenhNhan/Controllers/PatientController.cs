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

        public IHttpActionResult GetShortenPatient(int patientID)
        {
            ShortenPatient bn = dao.GetShortenPatient(patientID);
            if (bn == null)
            {
                return NotFound();
            }
            return Ok(bn);

        }
        public IHttpActionResult PostPatient([FromBody] Patient bn)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (dao.PostBenhNhan(bn) == false)
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
        public IHttpActionResult PutPatient([FromBody] Patient bn)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.PutBenhNhan(bn))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
        public IHttpActionResult DeletePatient(int PatientID)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.DeleteBenhNhan(PatientID))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
        public IHttpActionResult GetPatient_byName(string name)
        {
            List<Patient> list = dao.SearchBenhNhan2(name);
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
        //public  IHttpActionResult Delete_byName(string ServiceName)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest("Not a valid model");

        //    if (!dao.Search_DichVu2(ServiceName))
        //    {
        //        return BadRequest("Not a valid model");
        //    }

        //    return Ok();
        //}
    }
}
