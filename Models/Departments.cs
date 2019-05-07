using DiamondHRP.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Diamond_HRP_Pro_2017.Models
{
    public class Departments
    {
        Module m = new Module();
        public int deptID { get; set; }
        public string deptName { get; set; }
        public int parentDeptID { get; set; }
        public string deptCode { get; set; }
        public int reportGroup { get; set;}
        public string deptType { get; set; }
        public int isActive { get; set; }

        public DataTable Add_dept(string deptname, string parentdept, string deptcode, int chk, string deptType)
        {
            try
            {
                string sql = "call Insert_Dept('" + deptname + "','" + parentdept + "','" + deptcode + "','" + chk + "','" + deptType + "')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable load_depttype()
        {
            try
            {
                string sql = "call Load_DeptType()";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable add_deptType(string deptType,string deptdesc)
        {
            try
            {
                string sql = "call Insert_DeptType('" + deptType + "','"+deptdesc+"')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable loadParentList()
        {
            try
            {
                string sql = "call Load_ParentList()";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable update_Dept(string deptname, string parentdept, string deptcode, int chk, string deptType)
        {
            try
            {
                string sql = "call Update_Dept('" + deptname + "','" + parentdept + "','" + deptcode + "','" + chk + "','" + deptType + "')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
    }
   
}