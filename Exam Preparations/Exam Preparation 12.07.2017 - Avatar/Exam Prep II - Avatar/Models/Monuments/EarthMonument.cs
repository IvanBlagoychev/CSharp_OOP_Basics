﻿using System.Text;

public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int earthAffinity) : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    public int EarthAffinity
    {
        get { return this.earthAffinity; }
        set { this.earthAffinity = value; }
    }

    public override double GetAffinity()
    {
        return this.EarthAffinity;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString() + $"Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity}");
        return sb.ToString();
    }
}