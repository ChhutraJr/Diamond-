using Diamond_HRP_Pro_2017.Models;
using DiamondHRP.Controllers;
using MVCLogin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Diamond_HRP_Pro_2017.Controllers
{
    public class LoginController : Controller
    {
        Sessioner s = new Sessioner();
        // GET: Login
        public ActionResult Logins()
        {
            Module m = new Module();
            m.setConnection();
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string pass)
        {
                string mes = "";
            userlogin u = new userlogin();
            DataTable dt = u.GetUser(userName, pass);
            if (dt.Rows.Count > 0)
            {
                mes = "success";
               Session["logsucess"] = dt.Rows[0][0].ToString();
                s.ID= dt.Rows[0][0].ToString();
                s.Name = dt.Rows[0][1].ToString();
               
               

            }
            else
            {
                mes = "Plese check password and username again";
            }
            return Json(mes);
        }
        public ActionResult Logout()
        {
            Session["logsucess"] = null;
            return RedirectToAction("Logins", "Login");
        }
    }
}