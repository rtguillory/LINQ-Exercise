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

            foreach (string Game in OrderedByLength) { Console.WriteLine(Game); }
        }
    }
}
