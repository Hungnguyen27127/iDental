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
    public class MaterialIssueController : ApiController
    {
       
            MaterialIssueDAO dao = new MaterialIssueDAO();
            public IHttpActionResult GetMaterialIssue()
            {
            List<MaterialIssues> list = dao.GetMaterialIssue();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
            public IHttpActionResult PostMaterialIssue([FromBody] MaterialIssues lh)
            {
                if (!ModelState.IsValid)
                    return BadRequest("Not a valid model");

                if (dao.PostMaterialIssue(lh) == false)
                {
                    return BadRequest("Not a valid model");
                }

                return Ok();
            }
        }
    
}
