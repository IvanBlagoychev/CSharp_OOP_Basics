using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BankAccount
{
    private int id;
    private double balance;

    public int Id { get; set; }
    public double Balance { get; set; }

    public void Deposit(double ammount)
    {
        this.Balance += ammount;
    }
    public void Withdraw(double ammount)
    {
        this.Balance -= ammount;
    }
    public override string ToString()
    {
        return $"Account ID{this.Id}, balance {this.Balance:f2}";
    }
}