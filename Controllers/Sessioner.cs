using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiamondInventory.Models
{
    public class Sessioner
    {
        private string id = null;
        private string username = null;
        private string password = null;

        private void Refresh()
        {
            id = (string)HttpContext.Current.Session["ID"];
            username = (string)HttpContext.Current.Session["UserName"];
            password = (string)HttpContext.Current.Session["Password"];
        }

        private void SetID(string s)
        {
            if (s != "")
            {
                HttpContext.Current.Session["ID"] = s;
            }
            else
            {
                HttpContext.Current.Session["ID"] = null;
            }
        }
        private void SetUserName(string s)
        {
            if (s != "")
            {
                HttpContext.Current.Session["UserName"] = s;
            }
            else
            {
                HttpContext.Current.Session["UserName"] = null;
            }
        }
        private void SetPassword(string s)
        {
            if (s != "")
            {
                HttpContext.Current.Session["Password"] = s;
            }
            else
            {
                HttpContext.Current.Session["Password"] = null;
            }
        }
        //Property
        public string ID
        {
            get { Refresh(); return id; }
            set { SetID(value); }
        }
        public string UserName
        {
            get { Refresh(); return username; }
            set { SetUserName(value); }
        }
        public string Password
        {
            get { Refresh();return password; }
            set { SetPassword(value); }
        }
        //Reset Null
        public void SetAllNull()
        {
            SetID(null);
            SetUserName(null);
            SetPassword(null);
        }

        public bool isLogined
        {
            get
            {
                if (ID != null && UserName != null&& Password!=null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool isLogouted
        {
            get
            {
                if (UserName != null && ID != null && Password!=null)
                {
                    return false;
                }
                return true;
            }
        }
        public bool isNotEnough
        {
            get
            {
                if (UserName != null || ID != null|| Password!=null)
                {
                    return true;
                }
                return false;
            }
        }

    }
}