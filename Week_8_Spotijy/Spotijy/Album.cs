namespace Week_8_Spotijy.Spotijy;

public class Album
{
    public string Title { get; private set; }
    public int ReleaseYear { get; private set; }

    private List<Song> _songs;

    public List<Song> Songs
    {
        get => new List<Song>(_songs);
    }

    public Album(string title, int releaseYear)
    {
        _songs = new List<Song>();
        Title = title;
        ReleaseYear = releaseYear;
    }

    public void AddSongs(Song[] songs)
    {
        foreach (var song in songs)
        {
            if (!_songs.Contains(song))
            {
                _songs.Add(song);
            }
        }
    }


    public List<Song> Shuffle()
    {
        Random rnd = new Random();
        int random = rnd.Next(0, _songs.Count);

        // 0 1 2 3 4  -> 
        // 3
        // 3 4 0 1 2

        // map 
        var newIndexes = Enumerable
            .Range(0, _songs.Count)
            .Select(x => (x + random) % _songs.Count)
            .ToList(); //3 4 0 1 2
        // map 
        return newIndexes.Select(x => _songs[x]).ToList();
    }

    public List<Song> SortByTitle(bool ascending = true)
    {
        return ascending ? _songs.OrderBy(x => x.Title).ToList() : _songs.OrderByDescending(x => x.Title).ToList();
    }

    public List<Song> SortByDuration(bool ascending = true)
    {
        return ascending
            ? _songs.OrderBy(x => x.Duration).ToList()
            : _songs.OrderByDescending(x => x.Duration).ToList();
    }

    public List<Song> SortByYear(bool ascending = true)
    {
        return ascending
            ? _songs.OrderBy(x => x.ReleaseYear).ToList()
            : _songs.OrderByDescending(x => x.ReleaseYear).ToList();
    }

    public List<Song> SortByPopularity(bool ascending = true)
    {
        return ascending ? _songs.OrderBy(x => x.Likes).ToList() : _songs.OrderByDescending(x => x.Likes).ToList();
    }

    public List<Song> Reverse()
    {
        List<Song> reversed = new List<Song>(_songs);
        reversed.Reverse();

        return reversed;
    }

    public override string ToString()
    {
        return
            $"Title: {Title}, Release Year: {ReleaseYear}, Songs: [{string.Join(",", _songs.Select(x => x.ToString()))}]";
    }
}