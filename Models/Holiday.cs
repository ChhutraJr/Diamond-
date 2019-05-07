using DiamondHRP.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Diamond_HRP_Pro_2017.Models
{
    public class Holiday
    {
        Module m = new Module();
        public int HolidayID { get; set; }
        public string HolidayName { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public DataTable Add_Holiday(string holidayName,DateTime startDate,int duration)
        {
            try
            {
                string sql = "call Insert_Holiday('" + holidayName + "','" + Convert.ToDateTime(startDate).ToString("yyyy-MM-dd") + "','" + duration + "')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Load_Holiday()
        {
            try
            {
                string sql = "call Load_AllHoliday";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return m.objDataTable;
        }
        public DataTable Edit_Holiday(int id,string holidayName,DateTime startDate,int duration)
        {
            try
            {
                string sql = "call Update_Holiday('"+id+"','"+holidayName+"','"+ Convert.ToDateTime(startDate).ToString("yyyy-MM-dd") + "','"+duration+"')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Delete_Holiday(int id)
        {
            try
            {
                string sql = "call Delete_Holiday('" + id + "')";
                m.runCommandText(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
    }
}