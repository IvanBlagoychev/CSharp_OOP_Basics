using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Parent
{
    private string name;
    private string birthDay;

    public Parent(string name, string birthDay)
    {
        this.name = name;
        this.birthDay = birthDay;
    }

    public override string ToString()
    {
        return $"{this.name} {this.birthDay}";
    }
}
