using System;
using System.Linq;

public class WildFarm
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        
        while (input[0] != "End")
        {
            string type = input[0];
            string name = input[1];
            double weight = double.Parse(input[2]);
            string region = input[3];
            Animal animal = null;

            switch (type)
            {
                case "Cat":
                    var breed = input[4];
                    animal = new Cat(name, breed, weight, region);
                    break;
                case "Tiger":
                    animal = new Tiger(name, weight, region);
                    break;
                case "Mouse":
                    animal = new Mouse(name, weight, region);
                    break;
                case "Zebra":
                    animal = new Zebra(name, weight, region);
                    break;
            }

            animal.MakeSound();

            string[] foodInfo = Console.ReadLine().Split(' ').ToArray();
            string foodType = foodInfo[0];
            int foodQuantity = int.Parse(foodInfo[1]);
            Food food = null;

            if (foodType.Equals("Vegetable")) food = new Vegetable(foodQuantity);
            else if (foodType.Equals("Meat")) food = new Meat(foodQuantity);
            try
            {
                animal.Eat(food);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(animal);
            input = Console.ReadLine().Split(' ').ToArray();
        }
    }
}