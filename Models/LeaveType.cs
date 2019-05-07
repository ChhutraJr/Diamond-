using DiamondHRP.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Diamond_HRP_Pro_2017.Models
{
    public class LeaveType
    {
        Module m = new Module();
        public int LeaveID { get; set; }
        public string LeaveName { get; set; }
        public int CountLeaveBalance { get; set; }
        public double SalaryCoefficient { get; set; }
        public int PayNeverAbsent { get; set; }
        public double YearLeaveAllow { get; set; }
        public double AllowTakeLeave { get; set; }
        public double Duration { get; set; }
        public DataTable All_LeaveType(string LeaveName, int CountLeaveBalance, double SalaryCoefficient, int PayNeverAbsent, double YearLeaveAllow, double AllowTakeLeave, double Duration)

        {
            try
            {
                string sql = "call Insert_LeaveType('" + LeaveName + "','" + CountLeaveBalance + "','" + SalaryCoefficient + "','" + PayNeverAbsent + "','" + YearLeaveAllow + "','" + AllowTakeLeave + "','" + Duration + "')";
                m.fillDataTable(sql);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Load_LeaveType()
        {
            try
            {
                string sql = "call Load_LeaveType";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Edit_LeaveType(int id,string LeaveName, int CountLeaveBalance, double SalaryCoefficient, int PayNeverAbsent, double YearLeaveAllow, double AllowTakeLeave, double Duration)
        {
            try
            {
                string sql = "call Update_LeaveType('" + id + "','" + LeaveName + "','" + CountLeaveBalance + "','" + SalaryCoefficient + "','" + PayNeverAbsent + "','" + YearLeaveAllow + "','" + AllowTakeLeave + "','" + Duration + "')";
                m.fillDataTable(sql);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Delete_LeaveType(int id)
        {
            try
            {
                string sql = "call Delete_LeaveType('" + id + "')";
                m.runCommandText(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
    }
}