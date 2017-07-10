public abstract class Animal
{
    private string name;
    private int age;
    private bool isClensed;
    private AdoptionCenter originCenter;

    protected Animal(string name, int age, AdoptionCenter originCenter)
    {
        this.Name = name;
        this.Age = age;
        this.IsClensed = false;
        this.OriginCenter = originCenter;
    }

    public AdoptionCenter OriginCenter
    {
        get => this.originCenter;
        set => this.originCenter = value;
    }

    public bool IsClensed
    {
        get { return this.isClensed; }
        set { this.isClensed = value; }
    }
    public int Age
    {
        get { return this. age; }
        protected set { this.age = value; }
    }
    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }
}