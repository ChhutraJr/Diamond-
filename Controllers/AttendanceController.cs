using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diamond_HRP_Pro_2017.Controllers
{
    public class AttendanceController : Controller
    {
        public ActionResult DownloadAtt()
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
        public ActionResult UploadCollectedData()
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
        public ActionResult DailyAttendanceCalculation()
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
        public ActionResult ExceptionClock()
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
        public ActionResult DailyAttRecords()
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
        public ActionResult AllDailyAtt()
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
        public ActionResult AssignEmpShift()
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
        public ActionResult EmployeeLeaveRecords()
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
        public ActionResult EmployeeOutpassRecords()
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
        public ActionResult Holidays()
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