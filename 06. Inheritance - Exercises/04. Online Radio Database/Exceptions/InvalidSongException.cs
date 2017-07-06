using System;

public class InvalidSongException : Exception
{   
    public InvalidSongException() :base()
    {
    }
    public InvalidSongException(string message) :base(message)
    {
    }
}