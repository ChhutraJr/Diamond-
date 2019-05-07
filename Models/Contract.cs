using DiamondHRP.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Diamond_HRP_Pro_2017.Models
{
    public class Contract
    {
        Module m = new Module();
        Sessioner s = new Sessioner();
        public int ContractID { get; set; }
        public string ContractName { get; set; }
        public string ContractDesc { get; set; }
        public DataTable Add_Contract(string con_Name,string con_Desc)
        {
            try
            {
                string sql = "call Insert_Contract('" + con_Name + "','" + con_Desc + "','"+s.ID+"','"+s.ID+"')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable load_contract()
        {
            try
            {
                string sql = "call Load_Contract";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Edit_Contract(int id,string con_Name,string con_Desc)
        {
            try
            {
                string sql = "call Update_Contract('" + id + "','" + con_Name + "','" + con_Desc + "','" + s.ID + "')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable delete_Contract(int id)
        {
            try
            {
                string sql = "call Delete_Contract('" + id + "')";
                m.runCommandText(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
    }
}