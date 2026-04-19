namespace Week_7_1_OOP_Exercises_2.Task2;

public class MovieTicket
{
    private string _movieTitle;
    private int _row;
    private int _seat;
    private double _basePrice;
    private bool _isStudent;

    public MovieTicket(string movieTitle, int row, int seat, double basePrice, bool isStudent)
    {
        if (row < 1 || seat < 1 || basePrice < 0)
        {
            throw new ArgumentException("Invalid ticket parameters");
        }

        _movieTitle = movieTitle;
        _row = row;
        _seat = seat;
        _basePrice = basePrice;
        _isStudent = isStudent;
    }

    public double GetPrice()
    {
        return _basePrice;
    }

    public string GetMovieTitle() => _movieTitle;
    public int GetRow() => _row;
    public int GetSeat() => _seat;
    public bool IsStudent() => _isStudent;


    public double GetFinalPrice()
    {
        var price = _basePrice;
        if (_isStudent)
        {
            price *= 0.7;
        }

        if (IsPremiumSeat())
        {
            price += 3;
        } 
        return price;
    }

    public bool IsSameScreening(MovieTicket movieTicket)
    {
        throw new NotImplementedException();
    }

    public void MoveSeat(int newRow, int newSeat)
    {
        throw new NotImplementedException();
    }
    
    
    
    public bool IsPremiumSeat() => _row == 1 || _row == 2 || _row == 3;
    
    

    public override string ToString()
    {
        return $"Movie: {_movieTitle}, Row: {_row}, Seat: {_seat}, Price: {_basePrice}, Student: {_isStudent}";
    }
}