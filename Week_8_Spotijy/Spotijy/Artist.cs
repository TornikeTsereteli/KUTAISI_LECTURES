namespace Week_8_Spotijy.Spotijy;

public class Artist
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime BirthDate { get; private set; }
    private List<Album> _albums;
    private List<Song> _singles;
    
    public Artist(string firstName, string lastName, DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        _albums = new List<Album>();
        _singles = new List<Song>();
    }
    
    public Song? MostLikedSong()
    {
        
        Song? result = _singles.MaxBy(x=>x.Likes);
        foreach (var album in _albums)
        {
            Song? mostLiked = album.Songs.MaxBy(x => x.Likes);
            if (mostLiked is null)
            {
                continue;
            }

            if (result != null)
            {
                if (mostLiked.Likes > result.Likes)
                {
                    result = mostLiked;
                }
            }
        }

        return result;

    }
    
    public Song? MostLikedSong2()
    {
        List<Song> allSongs = _singles
            .Concat(_albums.SelectMany(x => x.Songs)).Distinct().ToList(); 
        return allSongs.MaxBy(x => x.Likes);
    }

    public int TotalLikes()
    {
        
        // [album1 album2]
        //album1.Songs = [song1 song2]
        //album2.Songs = [song3 song4]
        
        //  song1 song2 song3 song4
        List<Song> allSongs = _singles
            .Concat(_albums.SelectMany(x => x.Songs)).Distinct().ToList(); 

        return allSongs.Sum(x => x.Likes);
    }
    
}