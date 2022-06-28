using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CowabungaBankingLIB
{
    //public class Admin_Login : Security
    //{
    //    SqlConnection conn = new SqlConnection("server=KUAVO\\KUAVO10INSTANCE;database=CowabungaBankingAppDB;WindowsAuthentication;userType=Admin || Client");

    //    public bool CheckUserCredentials(string p_userName, string p_userPswd)
    //    {
    //        return CheckUserCredentials(p_userName, p_userPswd, Security.LoginTypes.admin);
    //    }
    //    public bool CheckUserCredentials(string p_userName, string p_userPswd, LoginTypes admin)
    //    {
    //        SqlCommand cmdCheckLogin = new SqlCommand("select count(*) from tbl_Login where userName = @userName and userPswd = @userPswd", conn);
    //        cmdCheckLogin.Parameters.AddWithValue("@userName", p_userName);
    //        cmdCheckLogin.Parameters.AddWithValue("userPswd", p_userPswd);
    //        conn.Open();
    //        int v_queryResult1 = Convert.ToInt32(cmdCheckLogin.ExecuteScalar());
    //        conn.Close();

    //        //v_queryResult1 = LoginTypes(Admin);
    //        //object value = bool(LoginTypes)admin;
    //    }


        //public string userType { get; set; }
        //public string userName { get; set; }
        //public string userPswd { get; set; }
        //public string userStatus { get; set; }
        //public int userAttempts { get; set; }



        //public int MyProperty { get; set; }
    //}
}
