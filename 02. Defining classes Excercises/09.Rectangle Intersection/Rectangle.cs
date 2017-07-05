public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double coordinateX;
    private double coordinateY;

    public Rectangle(string id, double width, double height, double x, double y)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.coordinateX = x;
        this.coordinateY = y;
    }

    public string Id { get { return this.id; }}

    public bool CheckIfIntersect(Rectangle rec)
    {
        if (this.coordinateX > rec.coordinateX + rec.width || rec.coordinateX > this.coordinateX + width)
        {
            return false;
        }
        if (this.coordinateY < rec.coordinateY - height || rec.coordinateY < this.coordinateY - height)
        {
            return false;
        }
        return true;
    }
}