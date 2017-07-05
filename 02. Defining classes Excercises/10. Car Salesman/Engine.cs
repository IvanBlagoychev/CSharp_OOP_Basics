using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private string model;
    private double power;
    private int? displacement;
    private string efficiency;

    public Engine(string model, double power)
    {
        this.model = model;
        this.power = power;
    }
    public Engine(string model, double power, int displacement) : this(model, power)
    {
        this.displacement = displacement;
    }
    public Engine(string model, double power, string efficiency) : this(model,power)
    {
        this.efficiency = efficiency;
    }
    public Engine(string model, double power, int displacement, string efficiency) : this(model,power)
    {
        this.displacement = displacement;
        this.efficiency = efficiency;
    }

    public string Model { get { return this.model; } }

    public override string ToString()
    {
        var engineData = string.Empty;
        var displacementData = this.displacement == null ? "n/a" : this.displacement.ToString();
        var efficiencyData = this.efficiency == null ? "n/a" : this.efficiency.ToString();
        engineData += Environment.NewLine + "  ";
        engineData += $"{this.Model}:";
        engineData += Environment.NewLine + "    ";
        engineData += $"Power: {this.power}";
        engineData += Environment.NewLine + "    ";
        engineData += $"Displacement: {displacementData}";
        engineData += Environment.NewLine + "    ";
        engineData += $"Efficiency: {efficiencyData}";
        return engineData;
    }
}