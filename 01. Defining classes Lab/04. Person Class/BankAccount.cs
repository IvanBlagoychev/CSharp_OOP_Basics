public class BankAccount
{
    private int id;
    private double balance;

    public int Id { get { return this.id; } set { this.id = value; } }
    public double Balance { get { return this.balance; } set { this.balance = value; } }

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