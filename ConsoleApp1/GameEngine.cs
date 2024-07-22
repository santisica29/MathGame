using ConsoleApp1.Models;
using System.Diagnostics;
using static ConsoleApp1.Models.Game;

namespace ConsoleApp1;

internal class GameEngine
{
    internal void DivisionGame(string message)
    {
        Stopwatch sw = Stopwatch.StartNew();

        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine($"Your answer was correct. Type any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Your answer was incorrect.");
                Console.ReadLine();
            }
        }
        
        sw.Stop();
        TimeSpan timeToCompletion = sw.Elapsed;
        string time = Helpers.FormatTimeSpanToStr(timeToCompletion);

        Console.WriteLine($"Game over. Your final score is {score}.\nIt took you {time} to finish the game. \nPress any key to go back to the main menu.");
        Console.ReadLine();

        Helpers.AddToHistory(score, GameType.Division, timeToCompletion);

    }
    internal void MultiplicationGame(string message)
    {
        Stopwatch sw = Stopwatch.StartNew();

        Console.WriteLine(message);

        var random = new Random();
        var score = 0;

        var difficulty = Helpers.GetGameDifficulty();

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var numbers = Helpers.GetRandomNumbers(difficulty);

            int firstNumber = numbers[0];
            int secondNumber = numbers[1];

            Console.WriteLine($"{firstNumber} * {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine($"Your answer was correct. Type any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Your answer was incorrect.");
                Console.ReadLine();
            }

        }

        sw.Stop();
        TimeSpan timeToCompletion = sw.Elapsed;
        string time = Helpers.FormatTimeSpanToStr(timeToCompletion);

        Console.WriteLine($"Game over. Your final score is {score}.\nIt took you {time} to finish the game. \nPress any key to go back to the main menu.");
        Console.ReadLine();

        Helpers.AddToHistory(score, GameType.Division, timeToCompletion);

    }
    internal void SubtractionGame(string message)
    {
        Stopwatch sw = Stopwatch.StartNew();

        Console.WriteLine(message);

        var random = new Random();
        var score = 0;

        var difficulty = Helpers.GetGameDifficulty();

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var numbers = Helpers.GetRandomNumbers(difficulty);

            int firstNumber = numbers[0];
            int secondNumber = numbers[1];

            Console.WriteLine($"{firstNumber} - {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine($"Your answer was correct. Type any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Your answer was incorrect.");
                Console.ReadLine();
            }

        }

        sw.Stop();
        TimeSpan timeToCompletion = sw.Elapsed;
        string time = Helpers.FormatTimeSpanToStr(timeToCompletion);

        Console.WriteLine($"Game over. Your final score is {score}.\nIt took you {time} to finish the game. \nPress any key to go back to the main menu.");
        Console.ReadLine();

        Helpers.AddToHistory(score, GameType.Division, timeToCompletion);

    }
    internal void AdditionGame(string message)
    {
        Stopwatch sw = Stopwatch.StartNew();

        Console.WriteLine(message);

        var random = new Random();
        var score = 0;

        var difficulty = Helpers.GetGameDifficulty();

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var numbers = Helpers.GetRandomNumbers(difficulty);

            int firstNumber = numbers[0];
            int secondNumber = numbers[1];

            Console.WriteLine($"{firstNumber} + {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine($"Your answer was correct. Type any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Your answer was incorrect.");
                Console.ReadLine();
            }

        }

        sw.Stop();
        TimeSpan timeToCompletion = sw.Elapsed;
        string time = Helpers.FormatTimeSpanToStr(timeToCompletion);

        Console.WriteLine($"Game over. Your final score is {score}.\nIt took you {time} to finish the game. \nPress any key to go back to the main menu.");
        Console.ReadLine();

        Helpers.AddToHistory(score, GameType.Division, timeToCompletion);
    }

    // internal accesibilty means that you can access the class with their methods from anywhere inside the project
    // keep in mind a solution can have many projects
}
