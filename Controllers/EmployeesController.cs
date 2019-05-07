using Diamond_HRP_Pro_2017.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diamond_HRP_Pro_2017.Controllers
{
    public class EmployeesController : Controller
    {
        MyModule my = new MyModule();
        // GET: Employees
        [HttpGet]
      
        public ActionResult EmpPersonalPro()
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
        public ActionResult SalaryInformation()
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
        public ActionResult DisciplinaryRecords()
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
        public ActionResult FPDownloadUpload()
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
        public ActionResult FPTransfer()
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