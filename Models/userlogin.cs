
using DiamondHRP.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace MVCLogin.Models
{
    public class userlogin
    {
        Module m = new Module();

        public DataTable GetUser(string userName, string pass)
        {
            string sql = "SELECT * FROM tbluser WHERE UserName='" + userName + "' and Passwd='" + pass + "'";
            m.fillDataTable(sql);
            return m.objDataTable;
        }
    }
}