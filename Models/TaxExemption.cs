using DiamondHRP.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Diamond_HRP_Pro_2017.Models
{
    public class TaxExemption
    {
        Module m = new Module();
        public int taxid { get; set; }
        public string exName { get; set; }
        public double exAmount { get; set; }
        public DataTable Add_TaxEx(string exemptionName,double amount)
        {
            try
            {
                string sql = "call Insert_TaxExemption('" + exemptionName + "','" + amount + "')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Load_TaxEx()
        {
            try
            {
                string sql = "call Load_AllTaxExemption";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Edit_TaxEx(int tid,string exName,double amount)
        {
            try
            {
                string sql = "call Update_TaxExemption('"+tid+"','"+exName+"','"+amount+"')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Delete_TaxEx(int tid)
        {
            try
            {
                string sql = "call Delete_TaxExemption('" + tid + "')";
                m.runCommandText(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
    }
}