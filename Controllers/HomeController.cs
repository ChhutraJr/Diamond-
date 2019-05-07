using Diamond_HRP_Pro_2017.Models;
using DiamondInventory.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diamond_HRP_Pro_2017.Controllers
{
    public class HomeController : Controller
    {
        MyModule my = new MyModule();
        DiamondInventory.Models.Sessioner s = new DiamondInventory.Models.Sessioner();
        // GET: Home
        public ActionResult index()
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
        public ActionResult TestTable()
        {
            return View();
        }
        public ActionResult ChangePassword()
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
        public ActionResult GroupAccessTemplate()
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
        public ActionResult UserAccessRight()
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
        public ActionResult CreateUser()
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
        public ActionResult LoadgroupName()
        {
            Users u = new Users();
            DataTable dt = u.LoadgroupName();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult LoadUsers()
        {
            Users u = new Users();
            DataTable dt = u.LoadUsers();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult DeleteUsers(int id)
        {
            Users u = new Users();
            DataTable dt = u.DelUsers(id);
            return Json("success");
        }
        public ActionResult EditUsers(int id, string username, string password, int groupId, int chk)
        {
            Users u = new Users();
            DataTable dt = u.EditUsers(id, username, password, groupId, chk);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult SaveUser(string username, string password, int groupid, int chk)
        {
            Users u = new Users();
            DataTable dt = u.AddUsers(username, password, groupid, chk);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult AddGroup(string groupname)
        {
            Users u = new Users();
            DataTable dt = u.AddGroupName(groupname);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult update(string username,string oldpass, string newpass,string conpass)
        {
            if(s.UserName !=username || s.Password!=oldpass)
            {
                return Json("Username or Password is not correct!");
            }
            else
            {
                Users u = new Users();
                DataTable dt = u.UpdatePass(username,oldpass,newpass);
                return Json("success");

            }
        }
    }
}