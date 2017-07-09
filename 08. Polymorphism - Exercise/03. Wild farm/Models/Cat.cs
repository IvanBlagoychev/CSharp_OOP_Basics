using System;
using System.Text;

public class Cat : Felime
{
    private string breed;

    public Cat(string animalName,string breed, double animalwiegth, string livingRegion) 
        : base(animalName, animalwiegth, livingRegion)
    {
        this.Breed = breed;
    }

    protected string Breed
    {
        get => this.breed;
        private set => this.breed = value;
    }

    public override void Eat(Food f)
    {
        base.FoodEaten += f.Quantity;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meowwww");
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{typeof(Cat)}[{base.Name}, {this.Breed}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]");
        return sb.ToString();
    }
}