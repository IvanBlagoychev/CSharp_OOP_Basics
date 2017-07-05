using System.Collections.Generic;
using System.Linq;

public class StackOfStrings
{
    private List<string> data;

    public StackOfStrings()
    {
        this.data = new List<string>();
    }

    public void Push(string item)
    {
        this.data.Add(item);
    }
    public string Pop(string item)
    {
        var result = this.data.Last();
        data.Remove(result);
        return result;
    }
    public string Peek(string item)
    {
        return this.data.First();
    }
    public bool IsEmpty()
    {
        return data.Count > 0;
    }
}