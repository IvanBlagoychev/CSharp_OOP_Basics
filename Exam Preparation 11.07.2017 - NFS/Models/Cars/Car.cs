using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;
    private int performancePoints;
    private int moneyWon;
   

    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
        this.PerformancePoints = 0;
        this.MoneyWon = 0;
    }

    public int PerformancePoints
    {
        get => this.performancePoints;
        set => this.performancePoints = value;
    }

    public int MoneyWon
    {
        get => this.moneyWon;
        set => this.moneyWon = value;
    }

    public int Durability
    {
        get { return this.durability; }
        protected set { this.durability = value; }
    }

    public int Suspension
    {
        get { return this.suspension; }
        set { this.suspension = value; }
    }

    public int Acceleration
    {
        get { return this.acceleration; }
        protected set { this.acceleration = value; }
    }
    
    public int Horsepower
    {
        get { return this.horsepower; }
        set { this.horsepower = value; }
    }
    
    public int YearOfProduction
    {
        get { return this.yearOfProduction; }
        protected set { this.yearOfProduction = value; }
    }
    
    public string Model 
    {
        get { return this.model; }
        protected set { this.model = value; }
    }
    
    public string Brand
    {
        get { return this.brand; }
        protected set { this.brand = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}")
            .AppendLine($"{this.Horsepower} HP, 100 m/h in {this.Acceleration} s")
            .AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");
        return sb.ToString();
    }

    public virtual void Tune(int tuneIndex, string addOns)
    {
        this.Horsepower = this.Horsepower + tuneIndex;
        this.Suspension += tuneIndex / 2;
    }
}

//A basic car has the following properties: a brand (string), a model (string), an yearOfProduction (int), horsepower (int), acceleration (int), suspension (int), and durability (int).