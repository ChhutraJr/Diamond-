using DiamondHRP.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Diamond_HRP_Pro_2017.Models
{
    public class TaxScheme
    {
        Module m = new Module();
        public int taxID { get; set; }
        public double salaryFrom { get; set; }
        public double salaryTo { get; set; }
        public double taxpercent { get; set; }
        public DataTable Load_taxScheme()
        {
            try
            {
                string sql = "call Load_taxScheme";
                 m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Add_TaxScheme()
        {
            try
            {
                string sql = "call Insert_TaxScheme('" + salaryFrom + "','" + salaryTo + "','" + taxpercent + "')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Update_taxScheme(int taxID, double salaryfrom, double salaryto, double tax)
        {
            try
            {
                string sql = "call Update_TaxScheme('"+ taxID + "','"+ salaryfrom + "','"+ salaryto + "','"+ tax + "')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return m.objDataTable;
        }
        public DataTable Delete_TaxScheme(int taxid)
        {
            try
            {
                string sql = "call Delete_TaxShceme('" + taxid + "')";
                m.runCommandText(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
    }
}