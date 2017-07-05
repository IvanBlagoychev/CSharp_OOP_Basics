using System;
using System.Collections.Generic;
using System.Linq;


public class RectangleIntersection
{
    static void Main()
    {
        var nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var list = new List<Rectangle>();
        for (int i = 0; i < nm[0]; i++)
        {
            var rectData = Console.ReadLine().Split(' ');
            var id = rectData[0];
            var width = double.Parse(rectData[1]);
            var height = double.Parse(rectData[2]);
            var x = double.Parse(rectData[3]);
            var y = double.Parse(rectData[4]);
            list.Add(new Rectangle(id, width, height, x, y));
        }
        for (int i = 0; i < nm[1]; i++)
        {
            var ids = Console.ReadLine().Split(' ');
            var firstRect = list.First(x => x.Id == ids[0]);
            var secondRect = list.First(x => x.Id == ids[1]);
            Console.WriteLine((firstRect.CheckIfIntersect(secondRect)).ToString().ToLower());
        }
    }
}