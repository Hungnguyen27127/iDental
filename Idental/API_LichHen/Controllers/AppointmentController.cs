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
    public class AppointmentController : ApiController
    {
        AppointmentDAO dao = new AppointmentDAO();
        public IHttpActionResult GetLH()//int employeeID
        {
            List<AppointmentShow> list = dao.GetLichHen();
            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }

        //Tim kiem  
        public IHttpActionResult Get_TheoID(int appointmentID)
        {
            Appointment res = dao.SearchLichHen(appointmentID);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        //LoadCombobox

        public IHttpActionResult GetDataForDoctorComboBox(bool getDoctor )
        {
            List<Doctor> list = dao.LoadDataForDoctorComboBox();
            if (getDoctor)
            {
                return Ok(list);
            }
            return NotFound();
            
        }

        public IHttpActionResult PostLichHen([FromBody] Appointment lh)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (dao.PostLichHen(lh) == false)
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }

        public IHttpActionResult PutLichHen([FromBody] Appointment lh)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.PutLichHen(lh))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }

        public IHttpActionResult DeleteLichHen(int AppointmentID)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            if (!dao.DeleteLichHen(AppointmentID))
            {
                return BadRequest("Not a valid model");
            }

            return Ok();
        }

    }
}
