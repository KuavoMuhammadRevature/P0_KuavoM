using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web.UI.MobileControls;
using CowabungaBankingLIB;

namespace CowaBungaBankingApp_2
{
    public enum UserType
    {
        Admin,
        Client
    };
    public class Program
    {
        static void Main(string[] args)
        {
            #region Variables and Objects
            Security secObj = new Security();
            Security newSec = new Security();
            Users userObj = new Users();
            Users newUser = new Users();
            TransactionsInfo trObj = new TransactionsInfo();
            TransactionsInfo newTransc = new TransactionsInfo();
            #endregion

            Console.WriteLine("~~~~~~~~~~Welcome to CowaBunga Banking!~~~~~~~~~~");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. CLient");
            int userType = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            int v_SearchByNo = 0;

            Console.WriteLine("Enter User Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string userPswd = Console.ReadLine();
            bool continueAPP = false;
            if (userType == 1)
            {
                string loginResult = userObj.Login(userName, userPswd, (Security.UserType)UserType.Admin);
                if (loginResult.Contains("Successful"))
                {
                    continueAPP = true;

                }
                else
                {
                    Console.WriteLine("Invalid Credentials Please Refresh CowaBunga and try again");
                }


                #region Start Admin Menu

                while (continueAPP == true)
                {
                    Console.Clear();

                    Console.WriteLine("1. Create New Account");
                    Console.WriteLine("2. View Account Detals By Account No");
                    Console.WriteLine("2. Perform Withdrawal FROM an Account");
                    Console.WriteLine("3. Perform Deposit TO an Account");
                    Console.WriteLine("5. Transfer Funds FROM Account 1 TO Account 2");
                    Console.WriteLine("6. Disable an Account");
                    Console.WriteLine("7. Activate an Account");
                    Console.WriteLine("8. Logout");

                    int choiceAdmin = Convert.ToInt32(Console.ReadLine());
                    v_SearchByNo = 0;
                    string v_Account = null;
                    #endregion

                    switch (choiceAdmin)
                    {

                        #region Add New User
                        case 1:

                            Console.WriteLine("Enter Name for New Account");
                            newUser.newUser = Console.ReadLine();

                            check = userObj.CheckUserExist(newUser.userName);
                            if (!check)
                            {
                                Console.WriteLine("Enter New Account Number");
                                newUser.accNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter New User Number");
                                newUser.userNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Type of User");
                                newUser.userType = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("Enter Type of Account");
                                newUser.accType = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("Enter Starting Balance");
                                newUser.accBalance = (float)Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter Account Status");
                                newUser.accStatus = Convert.ToString(Console.ReadLine());


                                Console.WriteLine("New User Added Successfully");
                            }
                            else
                            {
                                Console.WriteLine("Duplicate Employee Number");
                            }
                            break;
                        #endregion

                        #region Display All User Info in a List 
                        case 2:
                            Console.Clear();
                            List<Users> userList = new List<Users>();
                            int totalUsers = 0;

                            foreach (var item in userList)
                            {
                                Console.WriteLine("Enter Account Number to Search for a User and their information");
                                v_SearchByNo = Convert.ToInt32(Console.ReadLine());
                                newUser = userObj.SearchByNo(v_SearchByNo);
                                Console.WriteLine("User Account Number : " + newUser.userNo);
                                Console.WriteLine("User Account Type : " + newUser.userType);
                                Console.WriteLine("User Name : " + newUser.userName);
                                Console.WriteLine("User Account Balance : " + newUser.accBalance);
                                Console.WriteLine("User Account Status : " + newUser.userStatus);
                                Console.WriteLine("User Attempts to login are : " + newUser.userAttempts);
                                Console.WriteLine(" __________________________________________________________");

                                totalUsers = totalUsers++;
                                Console.WriteLine("Total Users = " + totalUsers);
                            }
                            break;
                        #endregion

                        #region Admin Performs a Withdrawal
                        case 3:

                            Console.WriteLine("Enter Account Number where you would like to make a Withdrawal");
                            v_SearchByNo = Convert.ToInt32(Console.ReadLine());
                            newUser = userObj.SearchByNo(v_SearchByNo);
                            Console.WriteLine("What amount do you wish to Withdraw?");
                            int amountToWithdraw = Convert.ToInt32(Console.ReadLine());
                            string withdraw = trObj.Withdrawals(amountToWithdraw, v_SearchByNo);
                            Console.WriteLine("Withdrawal Completed");

                            break;
                        #endregion

                        #region Adnin Performs a Deposit
                        case 4:

                            Console.WriteLine("Enter Account Number where you would like to Deposit");
                            v_SearchByNo = Convert.ToInt32(Console.ReadLine());
                            newUser = userObj.SearchByNo(v_SearchByNo);
                            Console.WriteLine("What amount do you wish to Deposit?");
                            int amountToDeposit = Convert.ToInt32(Console.ReadLine());
                            string deposit = trObj.Withdrawals(amountToDeposit, v_SearchByNo);
                            Console.WriteLine("Deposit Complete");

                            break;
                        #endregion

                        #region Admin Performs a Transfer

                        case 5:

                            Console.WriteLine("Enter Account No FROM which to transfer funds");
                            int fromAcc = Convert.ToInt32(Console.ReadLine());
                            newUser = userObj.SearchByNo(fromAcc);
                            Console.WriteLine("Enter Account No TO which to transfer funds");
                            int toAccount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Amount to transfer");
                            int Amount = Convert.ToInt32(Console.ReadLine());
                            string transferResult = trObj.Transfer(fromAcc, toAccount, Amount, (Security.UserType)UserType.Admin);
                            Console.WriteLine(transferResult);
                            Console.WriteLine("Transfer Done");

                            break;

                        #endregion

                        #region Admin Disables Account
                        case 6:

                            Console.WriteLine("Enter Account userName that you want to Disable");
                            v_Account = Console.ReadLine();
                            newSec = secObj.SearchByName(v_Account);
                            string disableAcc = secObj.DisableAccount(newSec);


                            break;
                        #endregion

                        #region Admin Activates a Disabled Account
                        case 7:

                            Console.WriteLine("Enter Account userName that you want to Disable");
                            v_Account = Console.ReadLine();
                            newSec = secObj.SearchByName(v_Account);
                            string activateAcc = secObj.ActivateAccount(newSec);


                            break;

                        #endregion

                        #region Admin Logout
                        case 8:

                            continueAPP = false;
                            Console.WriteLine("Logging Out as Admin");
                            Console.WriteLine("~~~~~~~~~~Thank You for using CowaBunga Banking!~~~~~~~~~~");
                            break;

                            #endregion
                    }
                }

            }

            #region Start Client Menu
            else
            {
                string loginResult2 = userObj.Login(userName, userPswd, (Security.UserType)UserType.Client);
                if (loginResult2.Contains("Successful"))
                {
                    continueAPP = true;

                }

                {
                    while (continueAPP == true)
                    {
                        Console.Clear();

                        Console.WriteLine("1. Check Available Balance");
                        Console.WriteLine("2. Make a Withdrawal");
                        Console.WriteLine("3. Make a Deposit");
                        Console.WriteLine("5. Transfer Funds to Account 2");
                        Console.WriteLine("6. View Last 10 Transactions");
                        Console.WriteLine("7. Change Password");
                        Console.WriteLine("8. Logout");

                        int choiceClient = Convert.ToInt32(Console.ReadLine());
                        v_SearchByNo = 0;
                        string v_Account = null;
                        #endregion

                        switch (choiceClient)
                        {
                            #region Client Checks Available Balance
                            case 1:
                                v_Account = userName;
                                List<Users> clientBals = userObj.CheckBalance(v_Account);
                                foreach (var item in clientBals)
                                {
                                    Console.WriteLine("Account Number : " + item.accNo);
                                    Console.WriteLine("Account Balance : " + item.accBalance);
                                }
                                break;

                            #endregion

                            #region Client Makes a Withdrawal
                            case 2:
                                v_Account = userName;
                                Console.WriteLine("How much do you want to Withdraw?");
                                int amountToWithdraw = Convert.ToInt32(Console.ReadLine());
                                string withdraw = trObj.UserWithdrawals(amountToWithdraw, v_Account);
                                Console.WriteLine("Withdrawal Completed");

                                break;

                            #endregion

                            #region Client Makes a Deposit
                            case 3:

                                v_Account = userName;
                                Console.WriteLine("How much do you want to deposit? ");
                                int amountToDeposit = Convert.ToInt32(Console.ReadLine());
                                string deposit = trObj.UserWithdrawals(amountToDeposit, v_Account);
                                Console.WriteLine("Deposit Complete");

                                break;

                            #endregion

                            #region Client Transfers to another account
                            case 4:

                                Console.WriteLine("Enter Account No TO transfer funds TO");
                                int toAccount = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Amount to transfer");
                                int Amount = Convert.ToInt32(Console.ReadLine());

                                string transferResult = trObj.UsersTransfer(userName, toAccount, Amount, (Security.UserType)UserType.Admin);
                                Console.WriteLine(transferResult);
                                Console.WriteLine("Transfer Done");

                                break;


                            #endregion

                            #region Client Views last 10 Transactions
                            case 5:


                                //


                                break;

                            #endregion

                            #region Client Changes Password
                            case 6:

                                Console.WriteLine("Enter New Password, NOTE this is Case Sensitive");
                                string n_userPswd = Convert.ToString(Console.ReadLine());
                                userPswd = n_userPswd;

                                Console.WriteLine("Password Changes Successfully");

                                break;

                            #endregion

                            #region Client Logout

                            case 8:


                                continueAPP = false;
                                Console.WriteLine("Logging Out as Client");
                                Console.WriteLine("~~~~~~~~~~Thank You for using CowaBunga Banking!~~~~~~~~~~");

                                break;

                                #endregion
                        }
                    }
                }

            }
        }
    }
}
