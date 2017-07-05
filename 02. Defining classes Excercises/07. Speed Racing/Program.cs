using System;
using System.Collections.Generic;


public class Speed
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var cars = new Dictionary<string, Car>();
        for (int i = 0; i < n; i++)
        {
            var car = Console.ReadLine().Split(' ');
            var model = car[0];
            var fuelAmmount = double.Parse(car[1]);
            var consumption = double.Parse(car[2]);
            cars.Add(model, new Car(model, fuelAmmount, consumption));
        }
        var input = Console.ReadLine().Split(' ');
        while (input[0] != "End")
        {
            if (input[0].Equals("Drive"))
            {
                var model = input[1];
                var distanseToTravel = int.Parse(input[2]);
                var currentCar = cars[model];
                currentCar.CanDriveDistance(distanseToTravel);
                cars[model] = currentCar;
            }

            input = Console.ReadLine().Split(' ');
        }
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.DistanceTravelled}");
        }
    }
}