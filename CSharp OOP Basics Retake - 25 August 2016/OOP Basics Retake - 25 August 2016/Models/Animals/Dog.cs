using System.Collections.Generic;

public class Dog : Animal
{
    private int ammountOfCommands;

    public Dog(string name, int age, int ammountOfCommands, AdoptionCenter originCenter) :base(name, age, originCenter)
    {
        this.AmmountOfCommands = ammountOfCommands;
    }
    public int AmmountOfCommands
    {
        get => this.ammountOfCommands;
        private set => this.ammountOfCommands = value;
    }
}