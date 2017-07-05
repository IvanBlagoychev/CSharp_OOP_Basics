public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelPerKilometer;
    private int distanceTravelled;

    public Car(string model, double fuelAmmount, double fuelPerKilometer)
    {
        this.Model = model;
        this.FuelAmount = fuelAmmount;
        this.FuelPerKilometer = fuelPerKilometer;
        this.DistanceTravelled = 0;
    }
    public string Model { get { return this.model; } set { this.model = value; } }
    public double FuelAmount { get { return this.fuelAmount; } set { this.fuelAmount = value; } }
    public double FuelPerKilometer { get { return this.fuelPerKilometer; } set { this.fuelPerKilometer = value; } }
    public int DistanceTravelled { get { return this.distanceTravelled; } set { this.distanceTravelled = value; } }

    public void CanDriveDistance(int kilometers)
    {
        
        var kilometersConsumption = kilometers * this.fuelPerKilometer;
        if (kilometersConsumption > this.fuelAmount)
        {
            System.Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.FuelAmount -= kilometersConsumption;
            this.DistanceTravelled += kilometers;
        }
    }
}