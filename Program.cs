namespace Interfaces_Price_Austin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game object
            Game game = new Game("FPS", "M", "Call of Battle");
            Console.WriteLine(game.Describe());
            game.PlayGame();

            Console.WriteLine();

            // Movie object
            Movie movie = new Movie("Horror", "R", "Night Terrors");
            Console.WriteLine(movie.Describe());
            movie.PlayMovie();
        }
         
    }
}

