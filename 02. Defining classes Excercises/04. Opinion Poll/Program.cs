using System;
using System.Collections.Generic;
using System.Linq;


public class OpinionPoll
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var people = new List<Person>();
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(' ');
            var newPerson = new Person()
            {
                Name = tokens[0],
                Age = int.Parse(tokens[1])
            };
            people.Add(newPerson);
        }
        people
            .Where(p => p.Age > 30)
            .OrderBy(g => g.Name)
            .Select(x => x)
            .ToList()
            .ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
    }
}