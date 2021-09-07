using System;

namespace Bank_Yarullin
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Account acc2 = new Account();
            Account acc3 = new Account();
            acc.Ballance = 10000;
            acc2.Ballance = 10500;
            acc3.Ballance = 12000;
            Operations.ShowBallance(acc);
            Operations.Transaction(acc, acc2, 2000.00);
            Operations.Widtraw(acc3, 2000.00);
            //Operations.Deposit(acc, 5000.00);
        }
    }
}
