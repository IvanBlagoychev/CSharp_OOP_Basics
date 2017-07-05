using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main()
    {
        int enginesNum = int.Parse(Console.ReadLine());
        var engines = new List<Engine>();
        var cars = new List<Car>();
        for (int i = 0; i < enginesNum; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var model = input[0];
            var power = double.Parse(input[1]);
            if (input.Length == 3)
            {   
                if (int.TryParse(input[2], out int displacement))
                {
                    engines.Add(new Engine(model, power, displacement));
                }
                else
                {
                    var efficiency = input[2];
                    engines.Add(new Engine(model, power, efficiency));
                }
            }
            else if (input.Length == 4)
            {
                var displacement = int.Parse(input[2]);
                var efficiency = input[3];
                engines.Add(new Engine(model, power, displacement, efficiency));
            }
            else engines.Add(new Engine(model, power));
        }
        var carsNum = int.Parse(Console.ReadLine());
        for (int i = 0; i < carsNum; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var carBrand = input[0];
            var engine = engines.Where(x => x.Model == input[1]).First();

            if (input.Length == 3)
            {
                if (int.TryParse(input[2], out int weight))
                {                                   
                    cars.Add(new Car(carBrand, engine, weight));
                }
                else
                {
                    var color = input[2];
                    cars.Add(new Car(carBrand, engine, color));
                }

            }
            else if (input.Length == 4)
            {
                var horsePower = input[2];
                var color = input[3];                
                cars.Add(new Car(carBrand, engine, double.Parse(horsePower), color));
            }
            else
            {
                cars.Add(new Car(carBrand, engine));
            }
        }
        cars.ForEach(c => Console.WriteLine(c.ToString()));
    }
}