using System;
using System.Linq;

public class AvatarExam
{
    static void Main()
    {

        try
        {
            var input = Console.ReadLine();
            var builder = new NationsBuilder();
            while (input != "Quit")
            {
                var tokens = input.Split(' ').ToList();
                switch (tokens[0])
                {
                    case "Bender":
                        builder.AssignBender(tokens);
                        break;
                    case "Monument":
                        builder.AssignMonument(tokens);
                        break;
                    case "Status":
                        Console.WriteLine(builder.GetStatus(tokens[1]));
                        break;
                    case "War":
                        builder.IssueWar(tokens[1]);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(builder.GetWarsRecord());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}