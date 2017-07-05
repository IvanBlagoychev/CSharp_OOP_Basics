using System;
using System.Reflection;


public class Program
{
    static void Main()
    {
        Type personType = typeof(Person);
        FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(fields.Length);


        var gosho = new Person()
        {
            name = "Gosho",
            age = 18
        };

        var pesho = new Person();
        pesho.name = "Pesho";
        pesho.age = 20;

        var stamat = new Person();
        stamat.name = "Stamat";
        stamat.age = 43;

        //Console.WriteLine(gosho.name);
        //Console.WriteLine(pesho.age);
    }
   
}