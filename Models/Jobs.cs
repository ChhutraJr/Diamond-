using DiamondHRP.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Diamond_HRP_Pro_2017.Models
{
    public class Jobs
    {
        Module m = new Module();
        public int jobPosID { get; set; }
        public string jobPosName { get; set; }
        public string jobPosKhmer { get; set; }
        public string jobPosChineese { get; set; }
        public string jobDesc { get; set; }

        public DataTable add_JobPos(string jobPosName,string jobPosinKhmer,string jobPosinChineese,string jobDesc)
        {
            try
            {
                string sql = "call Insert_JobPos('" + jobPosName + "','" + jobPosinKhmer + "','"+ jobPosinChineese + "','"+ jobDesc+"')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           return m.objDataTable;
        }
        public DataTable load_JobPos()
        {
            try
            {
                string sql = "call Load_JobPos()";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Update_JobPos(int jobID,string jobName,string jobinKhmer,string jobinChineese,string jobDesc)
        {
            try 
            {
               string sql = "call Update_JobPosition('" + jobID + "','" + jobName + "','" + jobinKhmer + "','" + jobinChineese + "','" + jobDesc + "')";
                m.fillDataTable(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable Del_JobPos(int jobID)
        {
            try
            {
                string sql = "call Delete_JobPos('" + jobID + "')";
                m.runCommandText(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
    }
}