using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diamond_HRP_Pro_2017.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult ReportHR()
        {
            if (Session["logsucess"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Logins", "Login");
            }
        }
        public ActionResult RptAttLeave()
        {
            if (Session["logsucess"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Logins", "Login");
            }
        }
        public ActionResult ReportPayroll()
        {
            if (Session["logsucess"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Logins", "Login");
            }
        }
        public ActionResult ReportMisc()
        {
            if (Session["logsucess"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Logins", "Login");
            }
        }
    }
}