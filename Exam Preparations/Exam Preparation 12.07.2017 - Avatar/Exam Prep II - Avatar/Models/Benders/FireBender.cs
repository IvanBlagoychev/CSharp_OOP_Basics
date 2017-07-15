using System.Text;

public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double heatAggression) : base(name, power)
        {
        this.HeatAggression = heatAggression;
    }

    public double HeatAggression
    {
        get => this.heatAggression;
        set => this.heatAggression = value;
    }

    public override double GetBenderTotalPower()
    {
        return this.Power * this.HeatAggression;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString() + $"Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAggression:f2}");
        return sb.ToString().Trim();
    }
}