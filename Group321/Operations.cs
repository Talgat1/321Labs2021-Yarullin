using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Yarullin
{
    class Operations
    {
        public static void ShowBallance(Account account)
        {
            Console.Write("Balans: ");
            System.Console.WriteLine(account.Ballance);
        }
        public static void Transaction(Account accountSeller, Account accountGetter, double summ)
        {
            if (accountSeller.Ballance >= summ && summ > 0)
            {
                accountSeller.Ballance -= summ;
                accountGetter.Ballance += summ;
                System.Console.WriteLine("Transaction completed: ");
                Console.WriteLine($"accountSeller Balans:{accountSeller.Ballance} transact {summ} accountGetter Balans:{accountGetter.Ballance}");
            }
            else
                Console.Write("The operation is not possible!");
        }
        public static void Widtraw(Account accountWid, double summ)
        {
            if (accountWid.Ballance >= summ && summ > 0)
            {
                accountWid.Ballance -= summ;
                System.Console.WriteLine("Widtraw completed: ");
                Console.WriteLine($"Your account has been withdrawn {summ} Balans:{accountWid.Ballance} ");
            }
            else
            {
                Console.Write("The operation is not possible!");
            }
        }
        public static void Deposit(Account accountDep, double summ, double mounth)
        {
            static void stavka(Account accountDep, double summ, double mounth)
            {
                accountDep.Ballance = accountDep.Ballance + summ * 0.057 / 12 * mounth;


            }
            if (summ > 0 && mounth > 0)
            {
                accountDep.Ballance += summ;
                System.Console.WriteLine("Invest completed: ");
                Console.WriteLine($"Your account has been received {summ} Balans:{accountDep.Ballance} ");
            }
            else
            {
                Console.Write("The operation is not possible!");
            }
        }
        public static void Credit(Account accountCred, double summ)
        {
            accountCred.Ballance += summ;
        }

    }
}
