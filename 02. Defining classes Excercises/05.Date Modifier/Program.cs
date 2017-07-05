using System;


public class Program
{
    static void Main()
    {
        var firstDateInput = Console.ReadLine().Split(' ');
        var secondDateInput = Console.ReadLine().Split(' ');
        var firstDate = new DateTime(int.Parse(firstDateInput[0]), int.Parse(firstDateInput[1]), int.Parse(firstDateInput[2]));
        var secondDate = new DateTime(int.Parse(secondDateInput[0]), int.Parse(secondDateInput[1]), int.Parse(secondDateInput[2]));
        var dateModifier = new DateModifier();
        Console.WriteLine(dateModifier.CalcDiff(firstDate, secondDate));
    }
}