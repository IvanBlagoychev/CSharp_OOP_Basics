using System;
using System.Reflection;


public class OldestMember
{
    static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        int n = int.Parse(Console.ReadLine());
        var family = new Family();
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(' ');
            var newPerson = new Person()
            {
                Name = tokens[0],
                Age = int.Parse(tokens[1])
            };
            family.AddMember(newPerson);
        }
        Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
    }
}