using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var accounts = new Dictionary<int, BankAccount>();
        while (input[0] != "End")
        {
            var cmd = input[0];
            switch (cmd)
            {
                case "Create":
                    Create(input, accounts);
                    break;
                case "Deposit":
                    Deposit(input, accounts);
                    break;
                case "Withdraw":
                    Withdraw(input, accounts);
                    break;
                case "Print":
                    Print(input, accounts);
                    break;
            }
            input = Console.ReadLine().Split(' ');
        }
    }

    private static void Print(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);
        if (!accounts.ContainsKey(id)) Console.WriteLine("Account does not exist");
        else Console.WriteLine($"Account ID{id}, balance {accounts[id].Balance:f2}");
    }

    private static void Withdraw(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);
        var ammount = double.Parse(input[2]);
        if (!accounts.ContainsKey(id)) Console.WriteLine("Account does not exist");
        else
        {
            if (accounts[id].Balance < ammount) Console.WriteLine("Insufficient balance");
            
            else accounts[id].Withdraw(ammount);
        }
    }

    private static void Deposit(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);
        var ammount = double.Parse(input[2]);
        if (!accounts.ContainsKey(id)) Console.WriteLine("Account does not exist");
        else accounts[id].Deposit(ammount);
        
    }

    private static void Create(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);
        if (accounts.ContainsKey(id)) Console.WriteLine("Account allready exists!");
        else
        {
            var newAccount = new BankAccount();
            newAccount.Id = id;
            accounts.Add(id, newAccount);
        }
    }
}