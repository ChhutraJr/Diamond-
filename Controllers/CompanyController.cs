using Diamond_HRP_Pro_2017.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diamond_HRP_Pro_2017.Controllers
{
    public class CompanyController : Controller
    {
        MyModule my = new MyModule();
        Sessioner s = new Sessioner();
        // GET: Company
        public ActionResult CompanyPreference()
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
        public ActionResult Departement()
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
        public ActionResult JopPosition()
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
        public ActionResult MachineInformation()
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
        public ActionResult Timetables()
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
        public ActionResult ShiftTemplate()
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
        public ActionResult LeaveTypes()
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
        public ActionResult TaxScheme()
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
        public ActionResult TaxExemption()
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
        public ActionResult MonthDefinition()
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
        public ActionResult Holiday()
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
        public ActionResult Contract()
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
        public ActionResult Insert_Dept(string deptname, string pa_dept, string deptcode, int chk, string deptType)
        {
            Departments d = new Departments();
            DataTable dt = d.Add_dept(deptname, pa_dept, deptcode, chk, deptType);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult load_Depttype()
        {
            Departments d = new Departments();
            DataTable dt = d.load_depttype();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult addDeptype(string dept_type, string dept_desc)
        {
            Departments d = new Departments();
            DataTable dt = d.add_deptType(dept_type, dept_desc);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult loadParentList()
        {
            Departments d = new Departments();
            DataTable dt = d.loadParentList();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult updateDept(string deptname, string pa_dept, string deptcode, int chk, string deptType)
        {
            Departments d = new Departments();
            DataTable dt = d.update_Dept(deptname, pa_dept, deptcode, chk, deptType);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult addJobPos(string posName, string posKhmer, string posChineese, string posDesc)
        {
            Jobs j = new Jobs();
            DataTable dt = j.add_JobPos(posName, posKhmer, posChineese, posDesc);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult load_JobPos()
        {
            Jobs j = new Jobs();
            DataTable dt = j.load_JobPos();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult update_job(int jobID, string posName, string posKhmer, string posChineese, string posDesc)
        {
            Jobs j = new Jobs();
            DataTable dt = j.Update_JobPos(jobID, posName, posKhmer, posChineese, posDesc);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Delete_JobPos(int jobID)
        {
            Jobs j = new Jobs();
            DataTable dt = j.Del_JobPos(jobID);
            return Json("success");
        }
        public ActionResult load_taxscheme()
        {
            TaxScheme t = new TaxScheme();
            DataTable dt = t.Load_taxScheme();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult add_TaxScheme(TaxScheme b)
        {

            DataTable dt = b.Add_TaxScheme();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Update_TaxScheme(int taxID, double salaryfrom, double salaryto, double tax)
        {
            TaxScheme t = new TaxScheme();
            DataTable dt = t.Update_taxScheme(taxID, salaryfrom, salaryto, tax);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Delete_TaxScheme(int taxID)
        {
            TaxScheme t = new TaxScheme();
            DataTable dt = t.Delete_TaxScheme(taxID);
            return Json("success");
        }
        public ActionResult Add_TaxExemption(string exemptionName, double amount)
        {
            TaxExemption te = new TaxExemption();
            DataTable dt = te.Add_TaxEx(exemptionName, amount);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Load_TaxEx()
        {
            TaxExemption te = new TaxExemption();
            DataTable dt = te.Load_TaxEx();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Edit_TaxEx(int tid, string exemptionName, double amount)
        {
            TaxExemption te = new TaxExemption();
            DataTable dt = te.Edit_TaxEx(tid, exemptionName, amount);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult delete_TaxEx(int tid)
        {
            TaxExemption te = new TaxExemption();
            DataTable dt = te.Delete_TaxEx(tid);
            return Json("success");
        }
        public ActionResult Add_Holiday(string holidayName, DateTime startDate, int duration)
        {
            Holiday h = new Holiday();

            DataTable dt = h.Add_Holiday(holidayName, startDate, duration);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Load_Holiday()
        {
            Holiday h = new Holiday();
            DataTable dt = h.Load_Holiday();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Edit_Holiday(int id, string holidayName, DateTime startDate, int duration)
        {
            Holiday h = new Holiday();
            DataTable dt = h.Edit_Holiday(id, holidayName, startDate, duration);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Delete_Holiday(int id)
        {
            Holiday h = new Holiday();
            DataTable dt = h.Delete_Holiday(id);
            return Json("success");
        }
        public ActionResult Add_Contract(string con_name, string con_desc)
        {
            Contract c = new Contract();
            DataTable dt = c.Add_Contract(con_name, con_desc);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult load_contract()
        {
            Contract c = new Contract();
            DataTable dt = c.load_contract();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Edit_Contract(int id, string con_name, string con_desc)
        {
            Contract c = new Contract();
            DataTable dt = c.Edit_Contract(id, con_name, con_desc);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult delete_Contract(int id)
        {
            Contract c = new Contract();
            DataTable dt = c.delete_Contract(id);
            return Json("success");
        }
        public ActionResult Add_LeaveType(string LeaveName, int chkBalance, double Salary_Coeffiecient, int chkPay, int YearLeaveAllow, int AllowTakeLeave, int MaxLeave)
        {
            LeaveType l = new LeaveType();
            DataTable dt = l.All_LeaveType(LeaveName, chkBalance, Salary_Coeffiecient, chkPay, YearLeaveAllow, AllowTakeLeave, MaxLeave);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Load_LeaveType()
        {
            LeaveType l = new LeaveType();
            DataTable dt = l.Load_LeaveType();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Edit_LeaveType(int id, string LeaveName, int chkBalance, double Salary_Coeffiecient, int chkPay, int YearLeaveAllow, int AllowTakeLeave, int MaxLeave)
        {
            LeaveType l = new LeaveType();
            DataTable dt = l.Edit_LeaveType(id,LeaveName, chkBalance, Salary_Coeffiecient, chkPay, YearLeaveAllow, AllowTakeLeave, MaxLeave);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult delete_LeaveType(int id)
        {
            LeaveType l = new LeaveType();
            DataTable dt = l.Delete_LeaveType(id);
            return Json("success");
        }
        public ActionResult Add_Month(string monthName, DateTime startDate, DateTime endDate, int chkallow,double totalWorkDay, double totalWorkHour, double originalWorkHour)
        {
            Months m = new Months();
            DataTable dt = m.Add_Month(monthName, startDate, endDate, chkallow, totalWorkDay, totalWorkHour, originalWorkHour);
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);
        }
        public ActionResult Load_Months()
        {
            Months m = new Months();
            DataTable dt = m.Load_Month();
            string response = my.DataTableToJSONWithJSONNet(dt);
            return Json(response);

        }
        public ActionResult Delete_Month(int id)
        {
            Months m = new Months();
            DataTable dt = m.Delete_Month(id);
            return Json("success");
        }
        public ActionResult CheckRow()
        {
            Months m = new Months();
         
            DateTime response = m.Check_Row();
            return Json(response.ToString());
           
        }
    }
}