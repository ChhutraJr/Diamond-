using System.IO;
using Microsoft.VisualBasic;

using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Security.Cryptography;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DiamondHRP.Controllers
{
    public class Module
    {
        public static int AdminLog = 0;
        public static int UserLog = 0;
        #region "Declaration"
        public string sqltext;

        public static MySqlConnection cn;
        public static MySqlCommand sqlCmd;
        public MySqlDataAdapter objDataAdapter;
        public DataTable objDataTable;
        public static string _DBName, _DBPwd, _UserID, _UserPwd, _HostAddress, _DBUser, _DBPort;
        public static string DBName, DBPwd, UserID, UserPwd, HostAddress, DBUser, DBPort;
        public const string REG_APPNAME = "SB Smart Sale (SBSS) V1.0";
        public const string REG_SECTION_DBSETTING = "DBSettings";
        public const string REG_KEY_DBName = "DBName";
        public const string REG_KEY_DBUSER = "DBUser";
        public const string REG_KEY_DBPWD = "DBPwd";
        public const string REG_KEY_PORT = "DBPort";
        public const string REG_KEY_HOST = "DBHost";
        public const string REG_KEY_UID = "UID";
        public const string REG_KEY_UPWD = "UserPwd";
        public const string SYSADMIN_ACCOUNT = "SysAdmin";
        public const string REG_KEY_LABNAME = "LabName";
      

        //Count Check Data
        public static int _count = 0;
        public static int _checkcount = 0;

        //Check child list active variable
        public static string _command="";
        public static string _group="";
        public static string _user="";
        public static string _department="";
        public static string _config = "";

        //All view header
        public static string appname = "Accounting Client Express - SHK";
        public static string appslogan = "Accounting Client Express";
        public static string boldappname = "Accounting";
        public static string spanappname = "Client Express";
        public static string homepic = "";
        public static string Oursoftware = "";
        //public static string Oursoftware = "Accounting Client Express is designed to help accounting firms manage their client" + 
        //                                   "information and inter-office communications as efficiently and accurately as possible." +
        //                                   "It provides a centralized, reliable, detailed and accurate client and business information" + 
        //                                   "repository as well as inter-office message tracking capability.";

        //Get all FK ID 
        public static string clientID;
        public static string addressID;
        public static string businessID;
        public static string companyID;
        public static string modifiedBy;
        public static string contactID;
        public static string distID;
        public static string lastmodifled = DateTime.Now.ToString("yyyy-MM-dd");

        #endregion

        public void Initialize()
        {

        }

        #region Connect TO Database
        public void setConnection()
        {
            try
            {
                StreamReader config = new StreamReader("Config/Config.dll");
                do
                {
                    string textstr;
                    textstr = config.ReadLine();
                    if (textstr.Contains("Database"))
                    {
                        SetDBName(textstr.Remove(0, 8));
                    }

                    if (textstr.Contains("Server"))
                    {
                        SetDBHost(textstr.Remove(0, 6));
                    }

                    if (textstr.Contains("User"))
                    {
                        SetDBUser(textstr.Remove(0, 5));
                    }

                    if (textstr.Contains("Password"))
                    {
                        SetDBPassword(textstr.Remove(0, 9));
                    }
                    if (textstr.Contains("Port"))
                    {
                        SetDBPort(textstr.Remove(0, 5));
                    }
                }
                while (config.Peek() > -1);

                DBPwd = GetDBPassword();
                DBName = GetDBName();
                DBUser = GetDBUser();
                HostAddress = GetDBHost();
                DBPort = GetDBPort();
                UserID = GetUserID();
                UserPwd = GetUserPassword();
                cn = new MySqlConnection();

                try
                {
                    //cn.ConnectionString = "Data Source=" + HostAddress + "," + "1433" + ";Network Library=DBMSSOCN;Initial Catalog =" + DBName + ";User ID =" + DBUser + "; Password =" + DBPwd + ";";
                    // cn.ConnectionString = "Initial Catalog=" + DBName + ";Data Source=" + HostAddress +","+ DBPort + ";user id=" + DBUser + ";password=" + DBPwd + ";Trusted_Connection=True;";
                    cn.ConnectionString = "DATABASE=" + DBName + ";" + "SERVER=" + HostAddress + ";user id=" + DBUser + ";" + "password=" + DBPwd + ";";
                    cn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot connect to your Database." + Environment.NewLine + "Report: " + ex.Message + Environment.NewLine + "Please contact software vendor for help.", "Security Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Windows.Forms.Application.Exit();
                }

                return;

            }
            catch (IOException e)
            {
                MessageBox.Show("System cannot connect to data store. Please configure your setting first." + e.Message, "SB Stock Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        public static string GetDBName()
        {
            return _DBName;
        }
        public static string GetDBPassword()
        {
            return _DBPwd;
        }
        public static string GetDBUser()
        {
            return _DBUser;
        }
        public static string GetDBHost()
        {
            return _HostAddress;
        }
        public static string GetDBPort()
        {
            return _DBPort;
        }
        public static string GetUserID()
        {
            return _UserID;
        }
        public static string GetUserPassword()
        {
            return _UserPwd;
        }
        public static void SetDBName(string sNewName)
        {
            _DBName = sNewName;
        }
        public static void SetDBUser(string sNewUser)
        {
            _DBUser = sNewUser;
        }
        public static void SetDBPassword(string sNewPwd)
        {
            _DBPwd = sNewPwd;
        }
        public static void SetDBHost(string sNewHost)
        {
            _HostAddress = sNewHost;
        }
        public static void SetDBPort(string sNewPort)
        {
            _DBPort = sNewPort;
        }
        public static void SetUserID(string sNewUID)
        {
            _UserID = sNewUID;
        }
        public static void SetUserPassword(string sNewPwd)
        {
            _UserPwd = sNewPwd;
        }
        #region "Run sqlCommand"
        public void runCommandText(string sql)
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            sqlCmd = new MySqlCommand();
            sqlCmd.Connection = cn;
            sqlCmd.CommandText = (sql);
            sqlCmd.ExecuteNonQuery();
            cn.Close();
        }
        #endregion
        #region "Run Function Command"
        public object runFunctionCommandText(string sql)
        {
            object x;
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            sqlCmd = new MySqlCommand();
            sqlCmd.Connection = cn;
            sqlCmd.CommandText = (sql);
            x= sqlCmd.ExecuteScalar();
            cn.Close();
            return x;
        }
        #endregion

        #region "Save To Database"
        public void Save(string table, string fieldname, string Value)
        {
            string sqlSave = "insert into " + table + " (" + fieldname + ")" + " Values(" + Value + ")";
            runCommandText(sqlSave);
        }
        #endregion
        #region "Update  Database"
        public void CommandTextUpdate(string tbl, string fields, string cond)
        {
            string sqlUpdate = "Update " + tbl + " Set " + fields + " Where " + cond + "";
            RunSql(sqlUpdate);
        }
        public void RunSql(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, cn);
                adapter.Fill(dt);
                dt.Dispose();
                adapter.Dispose();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region "Delete Data From Database"
        public void Delete(string tbl, string con)
        {
            string SqlDelete = "Delete From " + tbl + " Where " + con;
            RunSql(SqlDelete);
        }
        #endregion

        #region "Fill Datatable"
        public void fillDataTable(string sql)
        {
            try
            {
                sqlCmd = new MySqlCommand(sql, cn);
                objDataAdapter = new MySqlDataAdapter();
                objDataAdapter.SelectCommand = sqlCmd;


                objDataTable = new DataTable();
                objDataAdapter.Fill(objDataTable);
                objDataAdapter.Dispose();
                objDataAdapter = null;
                sqlCmd.Dispose();
                sqlCmd = null;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion
        #region "Convert From Binary to Image"
        //Convert From Binary to Image   
        public static Image BinarytoImage(byte[] imageByteArray)
        {
            Image newImage = null;
            MemoryStream Ms = new MemoryStream();
            if (imageByteArray.GetUpperBound(0) > 0)
            {
                Ms = new MemoryStream(imageByteArray);
                newImage = Image.FromStream(Ms);
                Ms = null;
            }
            return newImage;
        }
        #endregion


        public string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }

        #region Check Active Child List in _Layout.cshtml

        public void checkchildlist(string child)
        {
            if (child == "1")
            {
                _command = "active";
                _department = "";
                _group = "";
                _user = "";
                _config = "";
            }
            if (child == "2")
            {
                _command = "";
                _department = "";
                _group = "active";
                _user = "";
            }
            if (child == "3")
            {
                _command = "";
                _department = "active";
                _group = "";
                _user = "";
                _config = "";
            }
            if (child == "4")
            {
                _command = "";
                _department = "";
                _group = "";
                _user = "active";
                _config = "";
            }
            if (child == "5")
            {
                _command = "";
                _department = "";
                _group = "";
                _user = "";
                _config = "active";
            }
        }
        #endregion

        #region "Check Valid Email"
        public Boolean ValidateEmail(string mail)
        {
            try
            {
                MailAddress m = new MailAddress(mail);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        #endregion

        #region Get ClientId
        public void GetClientId()
        {
            string sql = "EXEC Get_ProspectiveClientId";
            fillDataTable(sql);
            if (objDataTable.Rows.Count > 0)
            {
               clientID = objDataTable.Rows[0][0].ToString();           
            }
        }
        #endregion
    
    }
}