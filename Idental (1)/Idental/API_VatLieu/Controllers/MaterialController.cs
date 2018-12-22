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
    public class MaterialController : ApiController
    {
        MaterialDAO dao = new MaterialDAO();
        public IHttpActionResult GetMaterial()
        {
            List<MaterialShow> list = dao.GetVatTu();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }
        public IHttpActionResult Get_TheoID(int id)
        {
            MaterialShow res = dao.SearchVatLieu(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        public IHttpActionResult GetDataForProviderComboBox(bool getProvider)
        {
            List<Provider> list = dao.LoadDataForProviderComboBox();
            if (getProvider)
            {
                return Ok(list);
            }
            return NotFound();

        }

        public IHttpActionResult PostMaterial([FromBody] Material vt)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (dao.PostVatTu(vt) == false)
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }

        public IHttpActionResult PutMaterial([FromBody] Material vt)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.PutVatTu(vt))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }

        public IHttpActionResult DeleteMaterial(int MaterialID)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.DeleteVatTu(MaterialID))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }
    }
}
