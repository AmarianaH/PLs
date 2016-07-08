using System;

namespace AccountsLibb
{
    class Account
    {

        readonly int ID;
        readonly double Balance;
        public double account;
        readonly double overdraft;
        
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

        public int GetID()
        {
            return this.ID;
        }


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
                //Console.WriteLine("You Can't withraw this value!! Sorry for that !!! ");
                throw new ArgumentOutOfRangeException("You Can't withraw this value!! Sorry for that !!! ");
                return false;
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
            if (account2 == null || amount == 0) throw new ArgumentNullException("the account or the ammount is null");
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
