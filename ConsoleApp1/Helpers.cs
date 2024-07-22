using ConsoleApp1.Models;
using static ConsoleApp1.Models.Game;

namespace ConsoleApp1;

internal class Helpers
{
    static List<Game> games = new()
    {
        new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Substraction, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Substraction, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Substraction, Score = 0 },
        new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Substraction, Score = 5 },
    };

    internal static string GetName()
    {
        Console.WriteLine("Please type your name");

        var name = Console.ReadLine();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Enter a name please.\n");
            name = Console.ReadLine();
        }

        return name;
    }


    internal static void ViewPrevGames()
    {
        var gamesToShow = games.OrderByDescending(x => x.Score);

        if (gamesToShow.Count() == 0)
        {
            Console.WriteLine("There are no games recorded.");
            Console.ReadLine();
            return;
        }

        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("--------------------------");
        foreach (var game in gamesToShow)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
        }

        Console.WriteLine("--------------------------\n");
        Console.WriteLine("Press any key to go back to menu");
        Console.ReadLine();

    }

    internal static void AddToHistory(int score, GameType typeGame)
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

    internal static int[] GetRandomNumbers(string gameDifficulty)
    {
        var numbers = new int[2];

        var random = new Random();

        int firstNumber = 0;
        int secondNumber = 0;

        if (string.Compare(gameDifficulty, GameDifficulty.Easy.ToString(),StringComparison.OrdinalIgnoreCase) == 0)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
        }
        else if (string.Equals(gameDifficulty,GameDifficulty.Medium.ToString(), StringComparison.OrdinalIgnoreCase))
        {
            firstNumber = random.Next(1, 50);
            secondNumber = random.Next(1, 50);
        }
        else if (StringComparer.OrdinalIgnoreCase.Equals(gameDifficulty, GameDifficulty.Hard.ToString()))
        {
            firstNumber = random.Next(1, 100);
            secondNumber = random.Next(1, 100);
        }

        numbers[0] = firstNumber;
        numbers[1] = secondNumber;

        return numbers;
    }

    internal static string? ValidateResult(string? result)
    {
        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be a number. Try again.");
            result = Console.ReadLine();
        }
        return result;
    }

    internal static string GetGameDifficulty()
    {
        bool x = false;
        string diff = "";

        while (x == false)
        {
            Console.Clear();
            Console.WriteLine("Choose a difficulty: \n\nEasy - Medium - Hard\n");

            diff = Console.ReadLine().ToLower();

            if (diff == "easy" || diff == "medium" || diff == "hard")
            {
                x = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.ReadLine();
            }
        }

        return diff;
    }
}
