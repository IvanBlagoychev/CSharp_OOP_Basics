using System.Text;

public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public int WaterAffinity
    {
        get { return this.waterAffinity; }
        set { this.waterAffinity = value; }
    }

    public override double GetAffinity()
    {
        return this.WaterAffinity;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString() + $"Water Monument: {this.Name}, Water Affinity: {this.WaterAffinity}");
        return sb.ToString();
    }
}