using System;

public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double consumption, double airConditionConsumption, double tankCapacity)
        :base(fuelQuantity, consumption, airConditionConsumption, tankCapacity)
    { }

    public override void Drive(double distance)
    {
        var needFuel = distance * (base.Consumption + base.AirConditionConsumption);
        if (base.FuelQuantity > needFuel)
        {
            Console.WriteLine($"{typeof(Bus)} travelled {distance} km");
            base.FuelQuantity -= needFuel;
        }
        else Console.WriteLine($"{typeof(Bus)} needs refueling");
    }

    public override void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if (liters > base.TankCapacity - base.FuelQuantity)
        {
            Console.WriteLine("Cannot fit fuel in tank");
        }
        else base.FuelQuantity += liters;
    }

    public override void DriveEmpty(double distance)
    {
        var needFuel = distance * (base.Consumption);
        if (base.FuelQuantity > needFuel)
        {
            Console.WriteLine($"{typeof(Bus)} travelled {distance} km");
            base.FuelQuantity -= needFuel;
        }
        else Console.WriteLine($"{typeof(Bus)} needs refueling");
    }
}