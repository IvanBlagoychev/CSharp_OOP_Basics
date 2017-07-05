using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car
{
    public string model;
    public double speed;

    public Car(string model, double speed)
    {
        this.model = model;
        this.speed = speed;
    }

    public override string ToString()
    {
        return $"{this.model} {this.speed}";
    }
}