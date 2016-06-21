using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibb
{
    class Program
    {
        static void Main(string[] args)
        {
            string Choice;
            Account a;
            a = AccountFactory.CreateAccount(5000.00);
            do
            {
                Console.WriteLine(" -------------------Menu------------------------ ");
                Console.WriteLine("here's your menu :");
                Console.WriteLine("Deposit :              press d");
                Console.WriteLine("Withdraw :             press w");
                Console.WriteLine("view your balance :    press b");
                Console.WriteLine("Quiet :                press q");
                Console.WriteLine(" -------------------End Of Menu----------------- ");
                Console.WriteLine("");

                Choice = Console.ReadLine();
                double balance = 0;
                switch (Choice)
                {
                    case "d":
                        Console.WriteLine("enter the ammount to deposit: ");
                        balance = double.Parse(Console.ReadLine());
                        a.Deposit(balance);
                        Console.WriteLine("added successfuly");
                        break;
                    case "w":
                        Console.WriteLine("enter the ammount to withdraw: ");
                        balance = double.Parse(Console.ReadLine());
                        a.Withdraw(balance);
                        Console.WriteLine("withdrawn successfuly");
                        break;
                    case "b":
                        Console.WriteLine($"Your balance is : {a.account} ");
                        break;
                }
            }while (Choice != "q");
               
            // creating another account 
            Account a2;
            a2 = AccountFactory.CreateAccount(5000.00);
            Console.WriteLine($"hello user {a2.GetID()}, you are about to take money from user {a.GetID()} , enter your ammount: ");
            double ammount = double.Parse(Console.ReadLine());
            a2.Transfer(a,ammount);
            Console.WriteLine($"Your balance is : {a2.account}. and the other account's balance is: {a.account} ");

        }
    }
}