public class Cat : Animal
{
    private int inteligencyCoef;

    public Cat(string name, int age, int inteligencyCoef, AdoptionCenter originCenter) :base(name, age, originCenter)
    {
        this.InteligencyCoef = inteligencyCoef;
    }
    public int InteligencyCoef
    {
        get => this.inteligencyCoef;
        private set => this.inteligencyCoef = value;
    }
}