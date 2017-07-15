using System.Text;

public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power, double waterClarity) : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public double WaterClarity
    {
        get => this.waterClarity;
        set => this.waterClarity = value;
    }

    public override double GetBenderTotalPower()
    {
        return this.Power * this.WaterClarity;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString() + $"Water Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.WaterClarity:f2}");
        return sb.ToString().Trim();
    }
}