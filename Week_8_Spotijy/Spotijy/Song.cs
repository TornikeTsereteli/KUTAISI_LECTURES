namespace Week_8_Spotijy.Spotijy;

public class Song
{
    public string Title { get; private set; }

    public int ReleaseYear { get; private set; }

    public int Duration { get; private set; }

    public int Likes { get; private set; }

    public Song(string title, int realeaseYear, int duration)
    {
        if (realeaseYear < 1900)
        {
            throw new ArgumentException("Invalid year");
        }

        if (duration < 0 || duration > 720)
        {
            throw new ArgumentException("Invalid duration");
        }

        Title = title ?? throw new ArgumentNullException(nameof(title));
        ReleaseYear = realeaseYear;
        Duration = duration;
    }


    private void Like()
    {
        Likes++;
    }

    private void Unlike()
    {
        if (Likes > 0)
        {
            Likes--;
        }
    }


    public bool ChangeDuration(int duration)
    {
        if (duration < 0 || duration > 720)
        {
            return false;
        }

        Duration = duration;
        return true;
    }

    public override string ToString()
    {
        return $"|| Title: {Title}, Release Year: {ReleaseYear}, Duration: {Duration / 60.0f} minutes, Likes: {Likes} ||";
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Song)
        {
            return false;
        }
        
        Song other = (Song) obj;
        
        return Title == other.Title && ReleaseYear == other.ReleaseYear && Duration == other.Duration;
    }
}