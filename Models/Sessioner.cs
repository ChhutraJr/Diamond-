using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diamond_HRP_Pro_2017.Models
{
    public class Sessioner
    {
        private string id = null;
        private string name = null;
        private void Refresh()
        {
            id = (string)HttpContext.Current.Session["ID"];
            name = (string)HttpContext.Current.Session["Name"];
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
        private void SetName(string s)
        {
            if (s != "")
            {
                HttpContext.Current.Session["Name"] = s;
            }
            else
            {
                HttpContext.Current.Session["Name"] = null;
            }
        }
        public string ID
        {
            get { Refresh(); return id; }
            set { SetID(value); }
        }
        public string Name
        {
            get { Refresh(); return name; }
            set { SetName(value); }
        }
        public void SetAllNull()
        {
            SetID(null);
            SetName(null);
            
        }
        public bool isLogined
        {
            get
            {
                if (ID != null && Name != null)
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
                if (Name != null && ID != null)
                {
                    return false;
                }
                return true;
            }
        }

        public string UserName { get; internal set; }
    }
}