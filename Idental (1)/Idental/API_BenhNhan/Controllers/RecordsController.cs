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
    public class RecordsController : ApiController
    {
        RecordDAO dao = new RecordDAO();
        public IHttpActionResult GetRecord_TheoID()//int employeeID
        {
            List<RecordShow> list = dao.GetAll();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
        public IHttpActionResult GetRecord_TheoID(int PatientID)//int employeeID
        {
            List<RecordShow> list = dao.GetAllRecord(PatientID);
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }

        public IHttpActionResult PostPatient([FromBody] Record bn)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (dao.PostRecord(bn) == false)
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
      
        public IHttpActionResult PutPatient([FromBody] Record bn)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.PutRecord(bn))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
        public IHttpActionResult DeletePatient(int RecordID)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.DeleteRecord(RecordID))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }

    }
}
