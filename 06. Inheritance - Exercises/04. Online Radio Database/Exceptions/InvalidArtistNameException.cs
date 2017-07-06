public class InvalidArtistNameException : InvalidSongException
{
    public InvalidArtistNameException() :base()
    { }
    public InvalidArtistNameException(string message) :base(message)
    { }
}