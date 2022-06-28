using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web.UI.MobileControls;
using CowabungaBankingLIB;
namespace CowabungaBankingLIB

{
    public class Security
    {
        public Security()
        {
            
        }

        public bool CheckUserExist(string userName)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdCheck = new SqlCommand("select count(*) from LoginInfo where userName = @userName", con);
            cmdCheck.Parameters.AddWithValue("@userName", userName);
            con.Open();
            int count = (int)cmdCheck.ExecuteScalar();
            con.Close();
            if (count == 1)
            {
                return true;
            }
            return false;
        }

        public Security SearchByName(string userName)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdSearchByName = new SqlCommand("select * from LoginInfo where userName = @userName", con);
            cmdSearchByName.Parameters.AddWithValue("@userName", userName);
            Security search = new Security();
            con.Open();
            SqlDataReader readSearch = cmdSearchByName.ExecuteReader();
            if (readSearch.Read())
            {
                search.userName = readSearch[0].ToString();
            }
            else
            {
                readSearch.Close();
                con.Close();
                throw new Exception("Couldn't find Account specified");
            }
            readSearch.Close();
            con.Close();
            return search;
        }

        public string DisableAccount(Security secObj)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdDisable = new SqlCommand("update LoginInfo set accStatus = 'Diasabled', userAttempts = 3 where userName = @userName", con);
            cmdDisable.Parameters.AddWithValue("@userName", secObj.userName);
            con.Open();
            int disable = cmdDisable.ExecuteNonQuery();
            con.Close();
            return "Account is now Disabled";
        }
        public string ActivateAccount(Security secObj)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdActivate = new SqlCommand("update LoginInfo set accStatus = 'Active', userAttempts = 0 where userName = @userName", con);
            cmdActivate.Parameters.AddWithValue("@userName", secObj.userName);
            con.Open();
            int activate = cmdActivate.ExecuteNonQuery();
            con.Close();
            return "Account is now Active";
        }
        public int accNo { get; set; }
        public string userType { get; set; }
        public string userName { get; set; }
        public int userNo { get; set; }
        public string userPswd { get; set; }
        public string userStatus { get; set; }
        public int userAttempts { get; set; }

        public enum UserType
        {
            Admin,
            Client
        };
        public string Login(string userName, string userPswd, UserType userType)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdLogin;

            if (userType == UserType.Admin)
            {
                cmdLogin = new SqlCommand("select count(*) from LoginInfo where userName=@userName and userPswd=@userPswd", con);
            }
            else
            {
                cmdLogin = new SqlCommand("select count(*) from LoginInfo where userName=@userName and userPswd=@userPswd", con);
            }
              cmdLogin.Parameters.AddWithValue("@userName", userName);
              cmdLogin.Parameters.AddWithValue("@userPswd", userPswd);

            con.Open();
            int adminLogin = (int)cmdLogin.ExecuteScalar();
            con.Close();

            if (userType == UserType.Client)
            {
                SqlCommand cmdAttempts = new SqlCommand("select userStatus,userAttempts from LoginInfo where userName = @userName", con);
                SqlCommand updateAccount = new SqlCommand("update LoginInfo set userAttempts = userAttempts+1 where userName = @userName", con);

                cmdAttempts.Parameters.AddWithValue("@userName", con);
                con.Open();

                SqlDataReader readUser = cmdAttempts.ExecuteReader();


                if (readUser.Read())
                {
                   
                    string userStatus = readUser[0].ToString();
                    int userAttempts = (int)readUser[1];
                    readUser.Close();
                    if (adminLogin == 1 && userStatus == "Active")
                    {
                        return "Login Successful";
                    }
                    else
                    {
                        if (userAttempts == 3)
                        {
                            updateAccount = new SqlCommand("update Login set userStatus = 'Disabled' where userName=@userName", con);
                        }
                        else
                        {
                            updateAccount = new SqlCommand("update Login set userStatus = 'Blocked' where userName = @userName", con);
                        }
                        if (userStatus == "Blocked")
                        {
                            Console.WriteLine("Account is Blocked. Please contact Admin");
                        }
                        else
                        {
                            updateAccount = new SqlCommand("update Login set userAttempts=userAttempts+1 where userName=@userName", con);
                        }
                        updateAccount.Parameters.AddWithValue("@userName", userName);
                        updateAccount.ExecuteNonQuery();
                        return "Login Failed for User " + userName;
                    }
                }
                con.Close();
                return "Blank";
            }
                else
                {
                    if (adminLogin == 1)
                    {
                    return "Login Successful for Admin";
                    }
                    else
                    {
                        return "Login Failed for Admin";
                    }

                }
        }
        public string AddLogin(int accNo, string userType, string userName, string userPswd, string userStatus, int userAttempts)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand newLogin = new SqlCommand("insert into LoginInfo values(@accNo, @userType, @userName, @userPswd, @userStatus, @userAttempts)", con);
            newLogin.Parameters.AddWithValue("@accNo", accNo).Value = Console.ReadLine();
            newLogin.Parameters.AddWithValue("@userType", userType).Value = Console.ReadLine();
            newLogin.Parameters.AddWithValue("@userName", userName).Value = Console.ReadLine();
            newLogin.Parameters.AddWithValue("@userPswd", userPswd).Value = Console.ReadLine();
            newLogin.Parameters.AddWithValue("@userStatus", userStatus);
            newLogin.Parameters.AddWithValue("@userAttempts", userAttempts);
            con.Open();
            int result = newLogin.ExecuteNonQuery(); //this method returns number of records affected in datbase
            con.Close();
            return "Login Added Successfully";
        }



    }
}
