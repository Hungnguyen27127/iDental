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
    public class BillController : ApiController
    {
        BillDAO dao = new BillDAO();

        public IHttpActionResult GetDV(int patientID)//
        {
            List<BillExtend> list = dao.GetBillExtend(patientID);
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
       
        public IHttpActionResult GetHD_TheoID(int MedicalRecordID)//
        {
            List<Bill> list = dao.GetHoaDon(MedicalRecordID);
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
        public IHttpActionResult PutPaymentState([FromBody] Record bn)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.PutPaymentState(bn))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }



    }
   

}
