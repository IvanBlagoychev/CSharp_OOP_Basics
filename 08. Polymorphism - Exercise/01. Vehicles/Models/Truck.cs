using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double consumption, double airConditionConsumption, double tankCapacity)
        : base(fuelQuantity, consumption, airConditionConsumption, tankCapacity)
    { }

    public override void Drive(double distance)
    {
        var needFuel = distance * (base.Consumption + base.AirConditionConsumption);
        if (base.FuelQuantity > needFuel)
        {
            Console.WriteLine($"{typeof(Truck)} travelled {distance} km");
            base.FuelQuantity -= needFuel;
        }
        else Console.WriteLine($"{typeof(Truck)} needs refueling");
    }

    public override void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if(liters > base.TankCapacity - base.FuelQuantity)
        {
            Console.WriteLine("Cannot fit fuel in tank");
        }
        else base.FuelQuantity += 0.95 * liters;
    }
}