public class InvalidSongSecondsException : InvalidSongLengthException
{
    public InvalidSongSecondsException() : base()
    { }
    public InvalidSongSecondsException(string message) :base(message)
    { }
}