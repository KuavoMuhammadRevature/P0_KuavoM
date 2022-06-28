using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using System.Data.SqlClient;
using CowabungaBankingLIB;

namespace CowabungaBankingLIB
{
    public class Login : Security
    {
        public string Admin { get; set; }
        public string Client { get; set; }

        public int accNo { get; set; }
        public string userType { get; set; }
        public string userName { get; set; }
        public string userPswd { get; set; }
        public string userStatus { get; set; }
        public int userAttempts { get; set; }

    }

    public class Users : Security
    {
        public string userType { get; set; }
        public string accType { get; set; }
        public int accNo { get; set; }
        public string accName { get; set; }
        public float accBalance { get; set; }
        public string accStatus { get; set; } = "Active";
        public bool accOverdrawProtection { get; set; } = false;
        public int userNo { get; set; }
        public string newUser { get; set; }
        public string userName { get; set; }
        public int userAttempts { get; set; } = 0;
        public string userStatus { get; set; }


        #region Exception Handling
        public void EX(int accNo, string accName, float accBalance, string accStatus, bool accOverdrawProtection, string newUser)
        {


            if (accName.Length < 3)
            {
                throw new Exception("Name has to be minimum 3 characters");
            }
            if (accStatus != "Active")
            {
                throw new Exception("Account Status must be Active. Please Contact your Admin for further help");
            }
            if (accBalance < 100)
            {
                throw new Exception("Sorry cannot open your account, as initial funding needs to be greater than $100");
            }
            if (accBalance < 150 && accOverdrawProtection == false)
            {
                throw new Exception("Warning, Account Balance is low, if Balance enters the negative the Account will be subject to fines as Overdraw Protection is not enabled on this account.");
            }

        }
        public string AddUser(int accNo, int userNo, string userType, string accType, string userName, float accBalance, string userStatus, bool accOverDrawProtection)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdNewUser = new SqlCommand("insert into Users values(@accNo, @usreNo, @userType, @accType, @userName, @accBalance, @userStatus, @accOverDrawProtection)", con);

            cmdNewUser.Parameters.AddWithValue("@accNo", accNo).Value = Console.ReadLine();
            cmdNewUser.Parameters.AddWithValue("@userNo", userNo).Value = Console.ReadLine(); 
            cmdNewUser.Parameters.AddWithValue("@userType", userType).Value = Console.ReadLine();
            cmdNewUser.Parameters.AddWithValue("@accType", accType).Value = Console.ReadLine();
            cmdNewUser.Parameters.AddWithValue("@userName", userName).Value = Console.ReadLine();
            cmdNewUser.Parameters.AddWithValue("@accBalance", accBalance).Value = Console.ReadLine();
            cmdNewUser.Parameters.AddWithValue("@userStatus", userStatus).Value = Console.ReadLine();
            cmdNewUser.Parameters.AddWithValue("@accOverDrawProtection", accOverDrawProtection).Value = Console.ReadLine();
            con.Open();
            int newUser = cmdNewUser.ExecuteNonQuery(); //this method returns number of records affected in datbase
            if (true)
            {

            }
            con.Close();
            return "New User Added Successfully";
        }
        #endregion
        public Users()
        {

        }
        public Users SearchByNo(int userNo)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdSearchByNo = new SqlCommand("select * from Users where userNo = @userNo", con);
            cmdSearchByNo.Parameters.AddWithValue("@userNo", userNo);
            Users userInfo = new Users();

            con.Open();
            SqlDataReader searchByNo = cmdSearchByNo.ExecuteReader();
            if (searchByNo.Read())
            {
                userInfo.userNo = (int)searchByNo[0];

            }
            else
            {
                searchByNo.Close();
                con.Close();
                throw new Exception("Search Not Found");
            }

            searchByNo.Close();
            con.Close();
            return userInfo;
        }

        public List<Users> CheckBalance(string p_userName)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdChkBal = new SqlCommand("select accNo, accBalance from Users where userName = @userName", con);
            cmdChkBal.Parameters.AddWithValue("@userName", p_userName);
            con.Open();
            SqlDataReader readChkBal = cmdChkBal.ExecuteReader();
            List<Users> chkList = new List<Users>();
            while (readChkBal.Read())
            {
                chkList.Add(new Users()
                {
                    accNo = (int)readChkBal[0],
                    accBalance = (float)readChkBal[5]
                          
                });

            readChkBal.Close();
            con.Close();
            return chkList;
            }
            return chkList;
        }
        public string UserWithdrawals(float Amount, string userName)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdWithdraw = new SqlCommand("update Users set accBalance = accBalance - @Amount where userName = @userName", con);
            cmdWithdraw.Parameters.AddWithValue("@Amount", Amount);
            cmdWithdraw.Parameters.AddWithValue("@userName", userName);
            con.Open();
            cmdWithdraw.ExecuteNonQuery();
            if (Amount < 0)
            {
                throw new Exception("Sorry cannot allow withdrawing of negative amount");
            }
            if (Amount > accBalance)
            {
                throw new Exception("Insufficient Balance");
            }
            con.Close();
            return "Withdrawal Compeleted";
        }
        public string UserDeposits(float Amount, int userName)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdDeposit = new SqlCommand(" update Users set accBalance = accBalance + @Amount where userName = @userName", con);
            cmdDeposit.Parameters.AddWithValue("@Amount", Amount);
            cmdDeposit.Parameters.AddWithValue("@userName", userName);
            con.Open();
            cmdDeposit.ExecuteNonQuery();

            if (Amount < 0)
            {
                throw new Exception("Sorry cannot allow deposit of zero amount");
            }
            if (Amount > 100000)
            {
                throw new Exception("Deposit Amount exceeds app permission. Please visit your local branch for a deposit of this size");
            }

            con.Close();
            return "Deposit Completed";
        }
        public string UsersTransfer(string userName, int toAccount, int Amount, UserType userType)
        {
            SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
            SqlCommand cmdFrom = new SqlCommand("update Users set accBalance = accBalance - @Amount where userName=@userName", con);
            cmdFrom.Parameters.AddWithValue("@amount", Amount);
            cmdFrom.Parameters.AddWithValue("@userName",userName);

            SqlCommand cmdTo = new SqlCommand("update Users set accBalance = accBalance - @amount where accNo=@toAccount", con);
            cmdTo.Parameters.AddWithValue("@amount", Amount);
            cmdTo.Parameters.AddWithValue("@toAccount", toAccount);

            SqlCommand cmdTransaction = new SqlCommand("insert into TransactionInfo values(GETDATE(),@fromAccount,@toAccount,@Amount,@userType)", con);
            cmdTo.Parameters.AddWithValue("@fromAccount", userName);
            cmdTo.Parameters.AddWithValue("@toAccount", toAccount);
            cmdTo.Parameters.AddWithValue("@amount", Amount);
            cmdTo.Parameters.AddWithValue("@userType", userType);
            if (userType == 0)
            {
                cmdTransaction.Parameters.AddWithValue("@userType", "Admin");
            }
            else
            {
                cmdTransaction.Parameters.AddWithValue("@userType", "Client");
            }
            cmdTo.Parameters.AddWithValue("@userType", userType);

            con.Open();
            cmdFrom.ExecuteNonQuery();
            cmdTo.ExecuteNonQuery();
            cmdTransaction.ExecuteNonQuery();
            con.Close();

            return "Transfer Done";

        }


    }
}