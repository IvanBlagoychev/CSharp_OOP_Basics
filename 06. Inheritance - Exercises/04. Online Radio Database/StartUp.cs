using System;
using System.Collections.Generic;
using System.Linq;

public class OnlineRadioDB
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var list = new List<Song>();
        for (int i = 0; i < n; i++)
        {
            try
            {
                var tokens = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);                
                var artistName = tokens[0];
                var songName = tokens[1];
                var duration = tokens[2];
                var timeTokens = new List<long>();

                try
                {
                    timeTokens = duration.Split(':').Select(long.Parse).ToList();
                }
                catch (Exception)
                {

                    throw new InvalidSongLengthException("Invalid song length.");
                }

                long minutes = timeTokens[0];
                long seconds = timeTokens[1];
                var song = new Song(new Artist(artistName), songName, minutes, seconds);
                list.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        TimeSpan t = TimeSpan.FromSeconds(list.Sum(s => s.SongLength.TotalSeconds));
        string playlistLenght = $"{t.Hours:D1}h {t.Minutes:D1}m {t.Seconds:D1}s";
        Console.WriteLine($"Songs added: {list.Count}");
        Console.WriteLine($"Playlist length: {playlistLenght}");
    }
}