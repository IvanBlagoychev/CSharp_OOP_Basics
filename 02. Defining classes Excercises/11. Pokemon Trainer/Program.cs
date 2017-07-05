using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PokemonTrainer
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var trainers = new Dictionary<string, Trainer>();
        while (input[0] != "Tournament")
        {
            var trainername = input[0];
            var pokemonName = input[1];
            var pokemonElement = input[2];
            var pokemonHealth = int.Parse(input[3]);
            var newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            if (!trainers.ContainsKey(trainername))
            {
                trainers[trainername] = new Trainer(trainername);
            }
            trainers[trainername].AddPokemon(newPokemon);

            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        while (input[0] != "End")
        {
            foreach (var trainer in trainers.Values)
            {
                trainer.TryToAddBadge(input[0]);
            }
            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        var result = trainers.Values.OrderByDescending(b => b.Badges);
        Console.WriteLine(string.Join(Environment.NewLine, result));
    }



}