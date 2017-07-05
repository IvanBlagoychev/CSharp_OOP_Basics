using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Google
{
    static void Main()
    {
        var input = Console.ReadLine();
        var people = new Dictionary<string, Person>();
        
        while (input != "End")
        {
            var tokens = input.Split(' ');
            var personName = tokens[0];
            var command = tokens[1];
            if (!people.ContainsKey(personName))
            {
                var newPerson = new Person(personName);
                people.Add(personName, newPerson);

            }

            switch (command)
            {
                case "company": people[personName].Company = new Company(tokens[2], tokens[3], decimal.Parse(tokens[4])); break;
                case "car": people[personName].Car = new Car(tokens[2], double.Parse(tokens[3])); break;
                case "pokemon": people[personName].Pokemons.Add(new Pokemon(tokens[2], tokens[3])); break;
                case "parents": people[personName].Parents.Add(new Parent(tokens[2], tokens[3])); break;
                case "children": people[personName].Children.Add(new Child(tokens[2], tokens[3])); break;
                default: break;
            }

            input = Console.ReadLine();
        }
        var name = Console.ReadLine();
        Console.WriteLine(people.Values.Where(x => x.Name == name).First().ToString());
    }
}