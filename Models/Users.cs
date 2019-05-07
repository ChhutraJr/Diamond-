using DiamondHRP.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Diamond_HRP_Pro_2017.Models
{
    public class Users
    {
        Module m = new Module();
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int groupID { get; set; }
        public int isActive { get; set; }
       
        public DataTable LoadgroupName()
        {
            try
            {
                string sql = "call LoadGroupName";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable LoadUsers()
        {
            try
            {
                string sql = "call Load_AllUsers";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable AddUsers(string username,string password,int groupid,int chk)
        {
            try
            {
                string sql = "call Insert_Users('" + username + "','" + password + "','" + groupid + "','"+chk+"')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable DelUsers(int id)
        {
            try
            {
                string sql = "call Delete_Users('" + id + "')";
                m.runCommandText(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable EditUsers(int id,string username,string password,int groupId, int chk)
        {
            try
            {
                string sql = "call Update_Users('" + id + "','" + username + "','" + password + "','" + groupId + "','" + chk + "')";
                m.fillDataTable(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable AddGroupName(string groupname)
        {
            try
            {
                string sql = "call Insert_GroupName('" + groupname + "')";
                m.fillDataTable(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
        public DataTable UpdatePass(string username,string oldpass,string newpass)
        {
            try
            {
                string sql = "";
                m.runCommandText(sql);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return m.objDataTable;
        }
    }
}