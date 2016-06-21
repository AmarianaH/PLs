using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibb
{
    static class AccountFactory
    {
        static int runningID = 100;
        public static Account CreateAccount(double initialBalance)
        {
            Account account = new Account(runningID, initialBalance);
            account.Deposit(initialBalance);
            runningID += 1;
            if (account != null)
            {
                return account;
            }
            return null;
            
        }
    }
}
