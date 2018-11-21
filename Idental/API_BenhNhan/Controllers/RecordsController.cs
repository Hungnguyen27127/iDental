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
        public IHttpActionResult GetRecord_TheoID(int PatientID)//int employeeID
        {
            List<RecordShow> list = dao.GetAllRecord(PatientID);
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
    }
}
