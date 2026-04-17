namespace Interfaces_Price_Austin
{
    internal class Movie : IGenre
    {

        public string ESRB { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        // Constructor
        public Movie(string genre, string esrb, string title)
        {
            Genre = genre;
            ESRB = esrb;
            Title = title;
        }

        // Method
        public void PlayMovie()
        {
            Console.WriteLine("Movie is Starting, Ssssshhhhh");
        }

        // Describe method
        public string Describe()
        {
            return $"{Title} is a {Genre} movie rated {ESRB}.";
        }
    }
}

