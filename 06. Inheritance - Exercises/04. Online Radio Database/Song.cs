using System;

public class Song
{
    private Artist artist;
    private string songName;
    private long minutes;
    private long seconds;
    private TimeSpan songLength;


    public Song(Artist artist, string songName, long minutes, long seconds)
    {
        this.Artist = artist;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
        this.songLength = CalcSongLength(this.Minutes, this.Seconds);
    }

    public Artist Artist
    {
        get => this.artist;
        set => this.artist = value;
    }

    public string SongName
    {
        get => this.songName;
        set
        {
            if (value.Length < 3 || value.Length > 30) throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
            this.songName = value;
        }
    }

    public long Minutes
    {
        get => this.minutes;
        set
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
            }
            this.minutes = value;
        }
    }

    public long Seconds
    {
        get => this.seconds;
        set
        {
            if (value < 0 || value > 59)
            {
                throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
            }
            this.seconds = value;
        }
    }

    public TimeSpan SongLength => this.songLength;

    private TimeSpan CalcSongLength(long minutes, long seconds)
    {
        var secs = minutes * 60 + seconds;
        var result = TimeSpan.FromSeconds(secs);
        return result;
    }
}
