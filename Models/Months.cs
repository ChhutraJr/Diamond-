using DiamondHRP.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Diamond_HRP_Pro_2017.Models
{
    public class Months
    {
        Module m = new Module();
        public int monthID { get; set; }
        public string monthName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int allowCalculate { get; set; }
        public double totalWorkDay { get; set; }
        public double totalWorkHour { get; set; }
        public double originalWorkHour { get; set; }
        public DataTable Add_Month(string month, DateTime start, DateTime end, int chkallow, double twork_day, double twork_hour, double original)
        {
            try
            {
                string sql = "call Insert_Month('" + month + "','" + Convert.ToDateTime(start).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(end).ToString("yyyy-MM-dd") + "','" + chkallow + "','" + twork_day + "','" + twork_hour + "','" + original + "')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           return m.objDataTable;
        }
        public DataTable Load_Month()
        {
            try
            {
                string sql = "call Load_Month";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Delete_Month(int id)
        {
            try
            {
                string sql = "call Delete_Month('"+id+"')";
                m.runCommandText(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DateTime Check_Row()
        {
            DateTime dd =new DateTime();
            try
            {
                string sql = "call Check_Row";
               dd = (DateTime)m.runFunctionCommandText(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dd;
        }
    }
}