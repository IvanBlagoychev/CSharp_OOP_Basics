using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Trainer
{
    //Trainers have a name, number of badges and a collection of pokemon
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.name = name;
        this.badges = 0;
        this.pokemons = new List<Pokemon>();
    }

    public int Badges { get { return this.badges; } }

    public void AddPokemon(Pokemon pokemon)
    {
        this.pokemons.Add(pokemon);
    }

    public void TryToAddBadge(string element)
    {
        var countForElement = this.pokemons.Where(e=>e.Element == element).Count();
        if (countForElement > 0)
        {
            this.badges++;
        }
        else
        {
            this.pokemons.ForEach(p => p.Health -= 10);
            this.pokemons = this.pokemons.Where(h => h.Health > 0).ToList();
        }
    }

    public override string ToString()
    {
        return $"{this.name} {this.Badges} {this.pokemons.Count}";
    }
}