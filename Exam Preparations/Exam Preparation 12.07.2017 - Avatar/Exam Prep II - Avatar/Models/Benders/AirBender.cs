using System.Text;

public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public double AerialIntegrity
    {
        get => this.aerialIntegrity;
        set => this.aerialIntegrity = value;
    }

    public override double GetBenderTotalPower()
    {
        return this.Power * this.AerialIntegrity;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString() + $"Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegrity:f2}");
        return sb.ToString().Trim();
    }
}