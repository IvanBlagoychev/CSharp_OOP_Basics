public class InvalidSongNameException : InvalidSongException
{
    public InvalidSongNameException() : base()
    { }
    public InvalidSongNameException(string message) :base(message)
    { }
}