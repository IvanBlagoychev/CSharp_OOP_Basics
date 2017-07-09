using System;
using System.Linq;

public class Vehicles
{
    static void Main()
    {
        var carInfo = Console.ReadLine().Split(' ').ToArray();
        var carFuelQuantity = double.Parse(carInfo[1]);
        var carLitersPerkm = double.Parse(carInfo[2]);
        var carTankCapacity = double.Parse(carInfo[3]);
        Vehicle newCar = new Car(carFuelQuantity, carLitersPerkm, 0.9, carTankCapacity);

        var truckInfo = Console.ReadLine().Split(' ').ToArray();
        var truckFuelQuantity = double.Parse(truckInfo[1]);
        var truckLitersPerkm = double.Parse(truckInfo[2]);
        var truckTankCapacity = double.Parse(truckInfo[3]);
        Vehicle newTruck = new Truck(truckFuelQuantity, truckLitersPerkm, 1.6, truckTankCapacity);

        var busInfo = Console.ReadLine().Split(' ').ToArray();
        var busFuelQuantity = double.Parse(busInfo[1]);
        var busLitersPerkm = double.Parse(busInfo[2]);
        var busTankCapacity = double.Parse(busInfo[3]);
        Vehicle newBus = new Bus(busFuelQuantity, busLitersPerkm, 1.4, busTankCapacity);

        int rounds = int.Parse(Console.ReadLine());

        for (int i = 0; i < rounds; i++)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            

            switch (input[1])
            {
                case "Car": DriveOrRefuelCar(input[0], newCar, double.Parse(input[2])); break;
                case "Bus": DriveOrRefuelBus(input[0], newBus, double.Parse(input[2])); break;
                case "Truck": DriveOrRefuelTruck(input[0], newTruck, double.Parse(input[2])); break;
                default: break;
            }
        }
        Console.WriteLine($"{typeof(Car)}: {newCar.FuelQuantity:f2}");
        Console.WriteLine($"{typeof(Truck)}: {newTruck.FuelQuantity:f2}");
        Console.WriteLine($"{typeof(Bus)}: {newBus.FuelQuantity:f2}");
    }

    private static void DriveOrRefuelTruck(string cmd, Vehicle truck, double data)
    {
        if (cmd.Equals("Drive")) truck.Drive(data);
        else if (cmd.Equals("Refuel")) truck.Refuel(data);
    }

    private static void DriveOrRefuelBus(string cmd, Vehicle bus, double data)
    {
        if (cmd.Equals("Drive")) bus.Drive(data);
        else if (cmd.Equals("DriveEmpty")) bus.DriveEmpty(data);
        else if (cmd.Equals("Refuel")) bus.Refuel(data);
    }

    private static void DriveOrRefuelCar(string cmd, Vehicle car, double data)
    {
        if (cmd.Equals("Drive")) car.Drive(data);
        else if (cmd.Equals("Refuel")) car.Refuel(data);
    }
}