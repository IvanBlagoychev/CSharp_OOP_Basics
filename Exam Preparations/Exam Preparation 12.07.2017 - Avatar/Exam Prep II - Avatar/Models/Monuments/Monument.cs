using System.Text;

public abstract class Monument
{
    private string name;

    protected Monument(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public abstract double GetAffinity();

    public override string ToString()
    {
        return "";
    }
}