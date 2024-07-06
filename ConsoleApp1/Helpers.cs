using ConsoleApp1.Models;

namespace ConsoleApp1;

internal class Helpers
{
    static List<Game> games = new();

    internal static string GetName()
    {
        Console.WriteLine("Please type your name");
        var name = Console.ReadLine();
        return name;
    }


   internal static void ViewPrevGames()
    {
        if (games.Count == 0)
        {
            Console.WriteLine("There are no games recorded.");
            Console.ReadLine();
            return;
        }

        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("--------------------------");
        foreach (var game in games)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
        }

        Console.WriteLine("--------------------------\n");
        Console.WriteLine("Press any key to go back to menu");
        Console.ReadLine();

    }

    internal static void AddToHistory(int score, string typeGame)
    {
        games.Add(new Game
        {
            Date = DateTime.Now,
            Score = score,
            Type = typeGame,
        });
        // char.ToUpper(typeGame[0])+typeGame.Substring(1) makes typegame first letter string uppercase
    }


    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(0, 99);
        var secondNumber = random.Next(0, 99);

        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }
}
