namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            List<string> Games = new List<string>() { "Call of Duty", "Duck Hunt", "Pokemon Gold", "Skyrim", "Super Mario Bros", "Mario Kart", "Minecraft", "Animal Crossing" };
            
            foreach (string Game in Games) { Console.WriteLine(Game); } 

            var OrderedByLength = Games.OrderBy(Game => Game.Length);
            Console.WriteLine();
            foreach (string Game in OrderedByLength) { Console.WriteLine(Game); }

            var HasSpace = Games.Where(Game => Game.Contains(" ")).OrderBy(Game => Game);
            Console.WriteLine();
            foreach (string Game in HasSpace) { Console.WriteLine(Game);  }

            var Sum = Games.Sum(Game => Game.Length);
            Console.WriteLine();
            Console.WriteLine(Sum);
        }
    }
}
