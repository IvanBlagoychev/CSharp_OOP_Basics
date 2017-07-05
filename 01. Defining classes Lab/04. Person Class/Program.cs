using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Program
{
    static void Main()
    {
        var accounts = new List<BankAccount>();
        accounts.Add(new BankAccount() { Id = 1, Balance = 15 });
        accounts.Add(new BankAccount() { Id = 1, Balance = 15 });
        accounts.Add(new BankAccount() { Id = 1, Balance = 15 });
        accounts.Add(new BankAccount() { Id = 1, Balance = 15 });

        var person = new Person("Pehso", 18, accounts);

        Console.WriteLine(person.GetBalance());
    }
}