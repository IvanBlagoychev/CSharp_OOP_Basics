using System;


public class DateModifier
{
    public int difference;

    public int CalcDiff(DateTime firstDate, DateTime secondDate)
    {
        this.difference = Math.Abs((firstDate - secondDate).Days);
        return this.difference;
    }
}