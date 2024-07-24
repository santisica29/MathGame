using ConsoleApp1.Models;
using System.Diagnostics;
using static ConsoleApp1.Models.Game;

namespace ConsoleApp1;

internal class GameEngine
{

    internal void RandomGame(string message)
    {
        Stopwatch sw = Stopwatch.StartNew();

        Console.WriteLine(message);

        var score = 0;

        var difficulty = Helpers.GetGameDifficulty();
        int numOfQuestions = Helpers.GetNumberOfQuestions();

        for (int i = 0; i < numOfQuestions; i++)
        {
            Console.Clear();
            Console.WriteLine(message);
            
            char op = Helpers.GetRandomTypeOfGame();

            int[] numbers = Helpers.GetNumbersForGame(op, difficulty);

            int firstNumber = numbers[0];
            int secondNumber = numbers[1];

            Console.WriteLine($"{firstNumber} {op} {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == Helpers.GetResultOfOperation(firstNumber, secondNumber, op))
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

        Helpers.ShowFinalResult(score, numOfQuestions, time);

        Helpers.AddToHistory(score, GameType.Random, timeToCompletion, numOfQuestions);
    }
    internal void DivisionGame(string message)
    {
        Stopwatch sw = Stopwatch.StartNew();

        var score = 0;

        int numOfQuestions = Helpers.GetNumberOfQuestions();

        for (int i = 0; i < numOfQuestions; i++)
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

        Helpers.ShowFinalResult(score, numOfQuestions, time);

        Helpers.AddToHistory(score, GameType.Division, timeToCompletion, numOfQuestions);

    }
    internal void MultiplicationGame(string message)
    {
        Stopwatch sw = Stopwatch.StartNew();

        Console.WriteLine(message);

        var score = 0;

        var difficulty = Helpers.GetGameDifficulty();
        int numOfQuestions = Helpers.GetNumberOfQuestions();

        for (int i = 0; i < numOfQuestions; i++)
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

        Helpers.ShowFinalResult(score, numOfQuestions, time);

        Helpers.AddToHistory(score, GameType.Division, timeToCompletion, numOfQuestions);

    }
    internal void SubtractionGame(string message)
    {
        Stopwatch sw = Stopwatch.StartNew();

        Console.WriteLine(message);

        var score = 0;

        var difficulty = Helpers.GetGameDifficulty();
        int numOfQuestions = Helpers.GetNumberOfQuestions();

        for (int i = 0; i < numOfQuestions; i++)
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

        Helpers.ShowFinalResult(score, numOfQuestions, time);

        Helpers.AddToHistory(score, GameType.Division, timeToCompletion, numOfQuestions);

    }
    internal void AdditionGame(string message)
    {
        Stopwatch sw = Stopwatch.StartNew();

        Console.WriteLine(message);

        var score = 0;

        var difficulty = Helpers.GetGameDifficulty();

        int numOfQuestions = Helpers.GetNumberOfQuestions();

        for (int i = 0; i < numOfQuestions; i++)
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

        Helpers.ShowFinalResult(score, numOfQuestions, time);

        Helpers.AddToHistory(score, GameType.Division, timeToCompletion, numOfQuestions);
    }

    // internal accesibilty means that you can access the class with their methods from anywhere inside the project
    // keep in mind a solution can have many projects
}
