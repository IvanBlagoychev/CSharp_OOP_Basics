using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string name;
    public int age;

    public Person(): this("No name", 1)
    {        
    }
    public Person(int Age) :this("No name", Age)
    {
        this.age = Age;
    }
    public Person(string Name, int Age)
    {
        this.name = Name;
        this.age = Age;
    }
}