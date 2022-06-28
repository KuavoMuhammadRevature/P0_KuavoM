using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowaBungaBankingApp
{
    public class Client : Application
    {
        Console.WriteLine("~~~~~~~~~~Cowabunga Banking App~~~~~~~~~~");

            //unfinished

            bool continueApp = true;

                while (continueApp == true)
                {
                Console.WriteLine("~~~~~~~~~~Welcome to CowabungaBanking!~~~~~~~~~~");
                Console.WriteLine("1. View Available Balance);
                Console.WriteLine("2. Withdraw Funds");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Wire Funds");
                Console.WriteLine("5. View past transactions");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Provide details and documents to open a new account");
                        Console.WriteLine("Code Coming up soon");
                        break;
                    case 2:
                        Console.WriteLine("Enter Amount to withdraw");
                        Console.WriteLine("Enter the amount you wish to withdraw");
                        int v_wAmount = Convert.ToInt32(Console.ReadLine());
                        var savObj = new Savings(101, "test", 1000, true, true);
                        savObj.Withdrawal(v_wAmount);
                            break;
                    case 3:
                        Console.WriteLine("Enter amount to deposit");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Deposit of  " + deposit + "$ is successful");
                        break;
                    case 4:
                        Console.WriteLine("Wire Funds processing.......");
                        Console.WriteLine("Funds Transferred");
                        break;
                    case 5:
                        Console.WriteLine("Transaction History");
                        Console.WriteLine("transaction 1");
                        Console.WriteLine("transaction 2");
                        Console.WriteLine("transaction 3");
                        Console.WriteLine("transaction 4");
                        Console.WriteLine("transaction 5");
                        break;
                    case 6:
                        Console.WriteLine("Thank you for being with us.");
                        break;
                    default:
                        Console.WriteLine("Sorry. Choose another option");
                        break;

            }
       }
    }   
}
