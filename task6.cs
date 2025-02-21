// Task 6: Movie Rating System
// Task: Create a class Movie with:
// Private field _rating.
// Add a property Rating that:
// Allows setting a value between 1 and 5.
// Prints a warning if an invalid value is entered.
// In Main(), test the property with valid and invalid values.

class Movie
{
    private int _rating;

    public Movie()
    {
        this._rating = 0;
    }

    public int Rating
    {
        get { return this._rating; }
        set { this._rating = value; }
    }

    public void Rate(int rate)
    {
        if (rate <= 0 || rate > 5)
        {
            Console.WriteLine("Invalid value");
        }

        else 
        {
            Console.WriteLine("The value is valid");
            this.Rating = rate;
            return;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Movie movie = new Movie();

        while (true)
        {
            Console.Write("Please enter rate for exit -1 ");
            if (int.TryParse(Console.ReadLine(), out int myrate) == false)
            {
                Console.WriteLine("Please enter valid value");
                break;
            }

            if (myrate == -1){
                break;
            }

            else{
                movie.Rate(myrate);
            } 
        }
        
        Console.WriteLine($"Movie rate is {movie.Rating}");
    }
}



