using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Program
{
    static void Main()
    {
        var account = new BankAccount()
        {
            Id = 1,
            Balance = 3500
        };
        account.Deposit(200);
        account.Withdraw(1000);

        Console.WriteLine(account.ToString());
    }
}