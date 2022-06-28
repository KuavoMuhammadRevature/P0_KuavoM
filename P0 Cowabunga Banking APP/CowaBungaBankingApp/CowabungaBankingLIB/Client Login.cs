using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CowabungaBankingLIB
{
    public class Client_Login : Security
    {
    //    SqlConnection conn = new SqlConnection("server=KUAVO\\KUAVO10INSTANCE;database=CowabungaBankingAppDB;WindowsAuthentication;userType=Admin || Client");

    //    public bool CheckUserCredentials(string p_userName, string p_userPswd)
    //    {
    //        return CheckUserCredentials(p_userName, p_userPswd);
    //    }
       
    //    public bool CheckUserCredentials(string p_userName, string p_userPswd, LoginTypes p_loginTypes)
    //    {
    //        SqlCommand cmdCheckLogin = new SqlCommand("select count(*) from tbl_Login where userName = @userName and userPswd = @userPswd", conn);
    //        cmdCheckLogin.Parameters.AddWithValue("@userName", p_userName);
    //        cmdCheckLogin.Parameters.AddWithValue("userPswd", p_userPswd);
    //        conn.Open();
    //        int v_queryResult2 = Convert.ToInt32(cmdCheckLogin.ExecuteScalar());
    //        conn.Close();

    //        //v_queryResult1 = LoginTypes(Admin);
    //        //object value = bool(LoginTypes)admin;
    //    }
       




    //}
    //public virtual double Withdrawal(int p_withdrawalAmt)
    //{
    //    if (p_withdrawalAmt < 0)
    //    {
    //        throw new Exception("Sorry cannot allow ");
    //    }
    //    return accBalance;

    //}
    //public virtual double Deposit(int p_depositAmt)
    //{
    //    if (p_depositAmt < 0)
    //    {
    //        throw new Exception("Sorry cannot allow ");
    //    }
    //    return accBalance;

    }
}