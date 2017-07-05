public class Box
{
    private double legth;
    private double width;
    private double height;

    public Box(double legth, double width, double height)
    {
        this.legth = legth;
        this.width = width;
        this.height = height;
    }

    public double FindSurfaceArea()
    {
        return 2 * this.legth * this.width + 2 * this.width * this.height + 2 * this.legth * this.height;
    }
    public double FindLateralSurfaceArea()
    {
        return (2 * this.height) * (this.width + this.legth);
    }
    public double FindVolume()
    {
        return this.legth * this.height * this.width;
    }
}