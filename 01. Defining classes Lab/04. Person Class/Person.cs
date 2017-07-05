using System.Collections.Generic;
using System.Linq;


public class Person
{
    private int age;
    private string name;
    private List<BankAccount> accounts;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Accounts = new List<BankAccount>();
    }
    public Person(string name, int age, List<BankAccount> accounts)
    {
        this.Name = name;
        this.Age = age;
        this.Accounts = accounts;
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public List<BankAccount> Accounts
    {
        get { return this.accounts; }
        set { this.accounts = value; }
    }

    public double GetBalance()
    {
        return this.accounts.Sum(a => a.Balance);
    }
}