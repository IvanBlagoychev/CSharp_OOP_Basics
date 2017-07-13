using System.Text;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
           : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Stars = 0;
    }

    public int Stars
    {
        get { return this.stars; }
        private set { this.stars = value; }
    }

    public override string ToString()
    {
        return base.ToString() + $"{this.Stars} *";
    }

    public override void Tune(int tuneIndex, string addOns)
    {
        base.Tune(tuneIndex, addOns);
        this.Stars += tuneIndex;
    }
}

// ShowCar – a car made for showing off. Looking cool out there, bro.
// Has stars(int). (by default – 0)