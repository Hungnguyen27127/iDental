using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data_iDental.DAO;
using Data_iDental.Entities;

namespace API_DangNhap.Controllers
{
    public class LoginController : ApiController
    {
        AccountDAO dao = new AccountDAO();
        public IHttpActionResult GETLogin(string username)
        {
            Account res = dao.GETlogin(username);
            if (res.Password == "")
            {
                return NotFound();
            }
            return Ok(res);
        }
        public IHttpActionResult GetInfor(int accountID)
        {
            EmployeeShorten res = dao.GETlinfor(accountID);
            if (res.EmployeeName == "")
            {
                return NotFound();
            }
            return Ok(res);
        }
    }
}
