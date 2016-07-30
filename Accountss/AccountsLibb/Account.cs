using System;

//The project isn't a class library project
namespace AccountsLibb
{
    class Account
    {

        //The convention is to call it _Id.
        readonly int ID;

        //Unused variable
        readonly double Balance;
        public double account;
        readonly double overdraft;
        
        //Why this constructor isn't internal?
        /// <summary>
        /// this is the constructor for this calss! 
        /// </summary>
        /// <param name="id"> the id for this account </param>
        /// <param name="balance"> the balance of the account at the beginning </param>
        public Account(int id, double balance)
        {
            ID = id;
            Balance = balance;

            this.overdraft = -5000;
        }

        //This isn't a property. 
        //Should have been: int GetId { get { return ID; } }
        public int GetID() 
        {
            return this.ID;
        }

        //Where is the balance property?


        /// <summary>
        /// adding ammount to the account
        /// </summary>
        /// <param name="Depsum"> the ammount we want to add </param>
        public void Deposit(double Depsum)
        {
            this.account = this.account + Depsum;
        }

        /// <summary>
        /// withdraw ammount from the account, unless the account balance will pass the limit (overdraft)!  
        /// </summary>
        /// <param name="WdSum"> the ammount we want to withdraw it! </param>
        public bool Withdraw(double WdSum)
        {
            bool flg = false;
            double temp = this.account - WdSum;
            if (temp < overdraft)
            {
                //It isn't a good idea to print console messages. You are writing a class library that can run in an applicatoin that isn't a console applicatoin
                Console.WriteLine("You Can't withraw this value!! Sorry for that !!! ");
            }
            else
            {
                this.account = temp;
                flg = true;
            }
            return flg;
        }

        /// <summary>
        /// transfering ammount from this account to the account2.
        /// </summary>
        /// <param name="account2"> the second account that we wan't to add ammount to it.</param>
        /// <param name="amount"> the ammount we want to add.</param>
        public void Transfer(Account account2, double amount)
        {
            if (this.Withdraw(amount))
            {
                account2.Deposit(amount);
                Console.WriteLine("the ammount added successfuly. ");
            }
            else
            {
                Console.WriteLine("the first account don't have this ammount!");
            }
        }

    }
}
