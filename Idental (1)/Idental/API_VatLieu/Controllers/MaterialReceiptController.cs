using Data_iDental.DAO;
using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_VatLieu.Controllers
{
    public class MaterialReceiptController : ApiController
    {
        MaterialReceiptDAO dao = new MaterialReceiptDAO();
        public IHttpActionResult GetLH()//int employeeID
        {
            List<MaterialReceipts> list = dao.GetMaterialReceipt();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
        public IHttpActionResult PostMaterialReceipt([FromBody] MaterialReceipts lh)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (dao.PostMaterialReceipt(lh) == false)
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
    }
}
