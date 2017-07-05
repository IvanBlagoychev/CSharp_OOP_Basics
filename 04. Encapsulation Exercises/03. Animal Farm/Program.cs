using System;

public class AnimalFarm
{
    static void Main()
    {
        string name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        try
        {
            var newChicken = new Chicken(name, age);
            Console.WriteLine($"Chicken {newChicken.Name} (age {newChicken.Age}) can produce {newChicken.ProductPerDay} eggs per day.");
        }
        catch (Exception e) { Console.WriteLine(e.Message); }
    }
}