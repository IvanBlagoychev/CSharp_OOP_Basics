using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(' ');
            var model = tokens[0];
            var speed = int.Parse(tokens[1]);
            var power = int.Parse(tokens[2]);
            var cargoweight = int.Parse(tokens[3]);
            var cargotype = tokens[4];
            var tire1pressure = double.Parse(tokens[5]);
            var tire1age = int.Parse(tokens[6]);
            var tire2pressure = double.Parse(tokens[7]);
            var tire2age = int.Parse(tokens[8]);
            var tire3pressure = double.Parse(tokens[9]);
            var tire3age = int.Parse(tokens[10]);
            var tire4pressure = double.Parse(tokens[11]);
            var tire4age = int.Parse(tokens[12]);

            var newCar = new Car(model, speed, power, cargoweight, cargotype, tire1pressure, tire1age, tire2pressure, tire2age, tire3pressure, tire3age, tire4pressure, tire4age);
            cars.Add(newCar);
        }
        string cmd;
        switch (cmd = Console.ReadLine())
        {
            case "fragile": PrintFragile(cars);break;
            case "flamable": PrintFlamable(cars);break;
            default:break;
        }
    }

    private static void PrintFlamable(List<Car> cars)
    {
        cars.Where(c => c.CarCargo.Type == "flamable" && c.CarEngine.Power > 250).ToList().ForEach(n => Console.WriteLine(n.Model));
    }

    private static void PrintFragile(List<Car> cars)
    {
        cars.Where(c => c.CarCargo.Type == "fragile" && (c.CarTires.Where(t => t.Pressure < 1.0).ToList().Count > 0)).ToList().ForEach(n => Console.WriteLine(n.Model));
    }
}
