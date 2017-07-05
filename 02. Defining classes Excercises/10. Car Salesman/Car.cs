using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car
{
    private string model;
    private Engine engine;
    private double? weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
    }
    public Car(string model, Engine engine, string color) : this(model, engine)
    {
        this.color = color;
    }
    public Car(string model, Engine engine, double weigh) : this(model,engine)
    {
        this.weight = weigh;
    }
    
    public Car(string model, Engine engine, double weight, string color) : this(model, engine)
    {
        this.weight = weight;
        this.color = color;
    }

    public override string ToString()
    {
        var weightValue = this.weight == null ? "n/a" : Convert.ToString(this.weight);
        var colorValue = this.color == null ? "n/a" : Convert.ToString(this.color);
       
        //Convert.ToString(this.weight);
        return $"{this.model}:" + this.engine.ToString() +  Environment.NewLine + "  " + $"Weight: {weightValue}" + Environment.NewLine + "  " + $"Color: {colorValue}";
    }
}