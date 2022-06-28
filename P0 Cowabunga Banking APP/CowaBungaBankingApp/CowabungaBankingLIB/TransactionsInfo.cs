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
    public class TransactionsInfo : Users
    {
        SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");

        public TransactionsInfo()
        {
        }

        public void ViewAllTransactions(int trNo, DateTime calendar, int fromAccount, int toAccount, float Amount, string transferredBy)
            {

                SqlCommand cmdAllTransc = new SqlCommand("select * from TransactionInfo where fromAccount = @fromAccount", con);
                cmdAllTransc.Parameters.AddWithValue("@fromAccount", fromAccount);
                cmdAllTransc.Parameters.AddWithValue("@Amount", Amount);
                con.Open();

                SqlDataReader readAllTransc = cmdAllTransc.ExecuteReader();
                List<TransactionsInfo> TranscList = new List<TransactionsInfo>();

                while (readAllTransc.Read())
                {
                    TranscList.Add(new TransactionsInfo());
                    {
                        trNo = (int)readAllTransc[0];
                        calendar = (DateTime)readAllTransc[1];
                        fromAccount = (int)readAllTransc[2];
                        toAccount = (int)readAllTransc[3];
                        Amount = (float)readAllTransc[4];
                        transferredBy = (string)readAllTransc[5];
                    }
                }
                readAllTransc.Close();
                con.Close();
                Console.WriteLine(TranscList);
            }

            public string Withdrawals(float Amount, int accNo)
            {
                SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");

                SqlCommand cmdWithdraw = new SqlCommand("update Users set accBalance = accBalance - @Amount where accNo = @accNo", con);
                cmdWithdraw.Parameters.AddWithValue("@Amount", Amount);
                cmdWithdraw.Parameters.AddWithValue("@accNo", accNo);

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
            public string Deposits(float Amount, int accNo)
            {
                SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
                SqlCommand cmdDeposit = new SqlCommand(" update Users set accBalance = accBalance + @Amount where accNo = @accNo", con);
                cmdDeposit.Parameters.AddWithValue("@Amount", Amount);
                cmdDeposit.Parameters.AddWithValue("@accNo", accNo);
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

                con.Close ();
                return "Deposit Completed";
            }

            public string Transfer(int fromAccount, int toAccount, int Amount, UserType userType)
            {
                SqlConnection con = new SqlConnection("server = KUAVO\\KUAVO10INSTANCE; database = CowabungaBankingAppDB; integrated security=true;MultipleActiveResultSets=true");
                SqlCommand cmdFrom = new SqlCommand("update TransactionInfo set accBalance = accBalance - @Amount where accNo=@fromAccount", con);
                cmdFrom.Parameters.AddWithValue("@Amount", Amount);
                cmdFrom.Parameters.AddWithValue("@fromAccount", fromAccount);

                SqlCommand cmdTo = new SqlCommand("update TransactionInfo set accBalance = accBalance - @Amount where accNo=@toAccount", con);
                cmdTo.Parameters.AddWithValue("@Amount", Amount);
                cmdTo.Parameters.AddWithValue("@toAccount", toAccount);

                SqlCommand cmdTransaction = new SqlCommand("insert into TransactionInfo values(GETDATE(),@fromAccount,@toAccount,@Amount,@userType)", con);
                cmdTo.Parameters.AddWithValue("@fromAccount", fromAccount);
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
