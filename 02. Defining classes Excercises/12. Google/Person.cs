using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    private string name;
    
    public Person(string name)
    {
        this.name = name;
        this.Company = null;
        this.Car = null;
        this.Parents = new List<Parent>();
        this.Children = new List<Child>();
        this.Pokemons = new List<Pokemon>();
    }
    public string Name { get { return this.name; } }
    public Company Company { get; set; }
    public List<Parent> Parents { get; set; }
    public List<Child> Children { get; set; }
    public List<Pokemon> Pokemons { get; set; }
    public Car Car { get; set; }

    public override string ToString()
    {
        var result = string.Empty;
        result += $"{this.Name}\n";
        result += $"Company:\n";
        result += this.Company == null ? string.Empty : this.Company.ToString() + "\n";
        result += $"Car:\n";
        result += this.Car == null ? string.Empty : this.Car.ToString() + "\n";
        result += $"Pokemon:\n";
        result += this.Pokemons.Count == 0 ? string.Empty : string.Join(Environment.NewLine, this.Pokemons) + "\n";
        result += $"Parents:\n";
        result += this.Parents.Count == 0 ? string.Empty : string.Join(Environment.NewLine, this.Parents) + "\n";
        result += $"Children:\n";
        result += this.Children.Count == 0 ? string.Empty : string.Join(Environment.NewLine, this.Children);
        return result;
    }
}