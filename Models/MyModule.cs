using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Diamond_HRP_Pro_2017.Models
{
    public class MyModule
    {
        public static Boolean error_Page_Not_Found = false;
        public DateTime Datedefault = default(DateTime);

        public Boolean Findsymbol(string s)
        {
            string symbol = "-+/.,()*&^%$#@!~{:'<>? ";

            foreach (char ch in s)
                foreach (char chh in symbol)
                    if (chh == ch)
                        return true;
            return false;
        }

        public bool isEmail(string e)
        {
            var regex = new Regex(@"[a-z0-9A-Z!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9A-Z!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9A-Z](?:[a-zA-Z0-9-]*[a-z0-9A-Z])?\.)+[a-z0-9A-Z](?:[a-zA-Z0-9-]*[a-z0-9A-Z])?");
            return regex.IsMatch(e);
        }
        public bool isWebsite(string w)
        {
            var regex = new Regex(@"^(http:\/\/www.|https:\/\/www.|ftp:\/\/www.|www.){1}([0-9A-Za-z]+\.)");
            return regex.IsMatch(w);
        }
        public string toLower(string n)
        {
            return n.ToLower();
        }
        public string toUpper(string n)
        {
            return n.ToUpper();
        }
        public string RemoveSpace(string n)
        {
            return n.Replace(" ", String.Empty);
        }
        public string UppercaseFirstEach(string s)
        {
            char[] a = s.ToLower().ToCharArray();

            for (int i = 0; i < a.Count(); i++)
            {
                a[i] = i == 0 || a[i - 1] == ' ' ? char.ToUpper(a[i]) : a[i];

            }

            return new string(a);
        }

        public string ConvertDataTable(DataTable tb)
        {
            string data = "";
            int i = 0;
            int y = 0;

            if (tb.Rows.Count > 0)
            {
                for (i = 0; i < tb.Rows.Count; i++)
                {
                    for (y = 0; y < tb.Columns.Count; y++)
                    {
                        data += tb.Rows[i][y].ToString() + "~";
                    }
                    data += "^";
                }
            }
            return data;
        }
        //public string[] getoutputIDparameter(string[] parameter, string store)
        //{
        //    string[] ids = new string[parameter.Length];
        //    try
        //    {
        //        SqlCommand com = new SqlCommand(store, DiamonInventory.Controllers.Module.cn);
        //        SqlParameter[] outputIdParam = new System.Data.SqlClient.SqlParameter[parameter.Length];

        //        for (int i = 0; i < parameter.Length; i++)
        //        {
        //            outputIdParam[i] = new SqlParameter(parameter[i], SqlDbType.Int)
        //            {
        //                Direction = ParameterDirection.Output
        //            };
        //        }

        //        com.CommandType = CommandType.StoredProcedure;

        //        for (int i = 0; i < parameter.Length; i++)
        //        {
        //            com.Parameters.Add(outputIdParam[i]);
        //        }


        //        if (DiamonInventory.Controllers.Module.cn.State != ConnectionState.Open)
        //        {
        //            DiamonInventory.Controllers.Module.cn.Open();
        //        }
        //        com.ExecuteNonQuery();


        //        for (int i = 0; i < parameter.Length; i++)
        //        {
        //            ids[i] = (string)outputIdParam[i].Value;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return ids;
        //}



        //Sin Sarak 2017.09.02


        public String CheckNullDate(DateTime dt)
        {
            if (dt == default(DateTime))
            {
                return "0001-01-01";
            }
            return dt.ToString("yyyy-MM-dd");
        }

        public string CheckNullString(string s)
        {
            if (s == null)
            {
                s = "";
            }
            return s;
        }


        //Sin Sarak 2017.08.03
        public string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }

        //Sin Sarak 2017.10.25
        public bool CheckExtImage(string filename)
        {
            string ext = System.IO.Path.GetExtension(filename).ToLower();
            string[] exts = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".svg", ".jfif", ".jpeg 2000", ".exif", ".tiff", ".ppm", ".pgm", ".pbm", ".pnm", ".webp", ".hdr", ".bpg", ".3d", ".cgm" };
            foreach (string e in exts)
            {
                if (e == ext)
                {
                    return true;
                }
            }
            return false;
        }
    }
}