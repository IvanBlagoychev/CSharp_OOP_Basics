using System;
using System.Diagnostics;
using System.Text;

public class Tiger : Felime
{
    public Tiger(string animalName, double animalwiegth, string livingRegion) 
        : base(animalName, animalwiegth, livingRegion)
    { }

    public override void Eat(Food f)
    {
        if (f.GetType().Name != "Meat")
        {
            throw new ArgumentException($"{typeof(Tiger)}s are not eating that type of food!");
        }
        base.FoodEaten += f.Quantity;
    }

    public override void MakeSound()
    {
        Console.WriteLine("ROAAR!!!");
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{typeof(Tiger)}[{base.Name}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]");
        return sb.ToString();
    }
}