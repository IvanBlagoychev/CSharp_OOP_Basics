public class InvalidSongMinutesException : InvalidSongLengthException
{
    public InvalidSongMinutesException() :base()
    { }
    public InvalidSongMinutesException(string message) :base(message)
    { }
}