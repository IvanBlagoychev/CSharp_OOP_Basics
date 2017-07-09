using System.Text;

public abstract class Animal
{
    private string name;
    //private string type;
    private double weight;
    private string livingRegion;
    private int foodEaten;

    protected Animal(string animalName, double animalWeight,string livingRegion)
    {
        this.Name = animalName;
        //this.Type = animalType;
        this.Weight = animalWeight;
        this.LivingRegion = livingRegion;
        this.FoodEaten = 0;
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }
    //public string Type
    //{
    //    get => this.type;
    //    set => this.type = value;
    //}
    public double Weight
    {
        get => this.weight;
        set => this.weight = value;
    }
    public string LivingRegion
    {
        get => this.livingRegion;
        set => this.livingRegion = value;
    }

    public int FoodEaten
    {
        get => this.foodEaten;
        set => this.foodEaten = value;
    }

    public abstract void MakeSound();

    public abstract void Eat(Food f);
}