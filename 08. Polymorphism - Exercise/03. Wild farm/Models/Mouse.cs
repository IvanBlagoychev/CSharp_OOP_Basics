using System;
using System.Text;

public class Mouse : Mammal
{
    public Mouse(string animalName, double animalwiegth, string livingRegion) 
        :base(animalName, animalwiegth, livingRegion)
    { }

    public override void MakeSound()
    {
        Console.WriteLine("SQUEEEAAAK!");
    }

    public override void Eat(Food f)
    {
        if (f.GetType().Name != "Vegetable")
        {
            throw new ArgumentException($"{this.GetType()}s are not eating that type of food!");
        }
        base.FoodEaten += f.Quantity;
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{typeof(Mouse)}[{base.Name}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]");
        return sb.ToString();
    }
}