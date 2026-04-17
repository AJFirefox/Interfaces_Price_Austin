namespace Interfaces_Price_Austin
{
    internal class Game : IGenre
    {

        public string ESRB { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        // Constructor
        public Game(string genre, string esrb, string title)
        {
            Genre = genre;
            ESRB = esrb;
            Title = title;
        }


        // Method
        public void PlayGame()
        {
            Console.WriteLine("Game is Starting");
        }

        // Describe method
        public string Describe()
        {
            return $"{Title} is a {Genre} game rated {ESRB}.";
        }
    }
}

