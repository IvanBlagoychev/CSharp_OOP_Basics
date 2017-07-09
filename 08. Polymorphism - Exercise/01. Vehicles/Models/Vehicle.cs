using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double consumption;
    private double airConditionConsumption;
    private double tankCapacity;

    protected Vehicle(double fuelQuantity, double consumption, double airConditionConsumption, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.Consumption = consumption;
        this.AirConditionConsumption = airConditionConsumption;
        this.TankCapacity = tankCapacity;
    }

    public double FuelQuantity
    {
        get => this.fuelQuantity;
        protected set
        {
            if (value < 0) throw new ArgumentException("Fuel must be a positive number");
            else this.fuelQuantity = value;
        }
    }
    public double Consumption { get => this.consumption; protected set => this.consumption = value; }
    public double AirConditionConsumption { get => this.airConditionConsumption; protected set => this.airConditionConsumption = value; }
    public double TankCapacity { get => this.tankCapacity; protected set => this.tankCapacity = value; }

    public abstract void Drive(double distance);
    public abstract void Refuel(double liters);

    public virtual void DriveEmpty(double distance) { }
}