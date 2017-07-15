public abstract class Center
{
    private string name;

    protected Center(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get => this.name;
        private set => this.name = value;
    }
}