using System.Collections.Generic;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        :base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.AddOns = new List<string>();
        base.Horsepower = horsepower + ((horsepower * 50) / 100);
        base.Suspension = suspension - ((suspension * 25) / 100);
    }

    public List<string> AddOns { get => this.addOns; private set => this.addOns = value; }

    public override string ToString()
    {
        if (this.AddOns.Count > 0)
        {
            return base.ToString() + $"Add-ons: {string.Join(", ", this.AddOns)}";
        }
        
        return base.ToString() + "Add-ons: None";
    }

    public override void Tune(int tuneIndex, string addOns)
    {
        base.Tune(tuneIndex, addOns);
        this.AddOns.Add(addOns);
    }
}


// PerformanceCar – a car made for racing. Might be a little ugly, but it is a rocket inside.
// Has addOns(Collection of strings). (by default – empty)
// Increases its given horsepower by 50%.
// Decreases its given suspension by 25%.
