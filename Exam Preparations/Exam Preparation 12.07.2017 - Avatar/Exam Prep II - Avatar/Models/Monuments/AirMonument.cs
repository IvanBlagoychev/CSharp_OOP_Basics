using System.Text;

public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int airAffinity) : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public int AirAffinity
    {
        get { return this.airAffinity; }
        set { this.airAffinity = value; }
    }

    public override double GetAffinity()
    {
        return this.AirAffinity;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString() + $"Air Monument: {this.Name}, Air Affinity: {this.AirAffinity}");
        return sb.ToString();
    }
}