using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    
    public Box(double legth, double width, double height)
    {
        this.Length = legth;
        this.Width = width;
        this.Height = height;
    }

    public double Length
    {
        get { return this.length; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }
    public double Width
    {
        get { return this.width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }
    public double Height
    {
        get { return this.height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public double FindSurfaceArea()
    {
        return 2 * this.Length * this.Width + 2 * this.Width * this.Height + 2 * this.Length * this.Height;
    }
    public double FindLateralSurfaceArea()
    {
        return (2 * this.Height) * (this.Width + this.Length);
    }
    public double FindVolume()
    {
        return this.Length * this.Height * this.Width;
    }
}