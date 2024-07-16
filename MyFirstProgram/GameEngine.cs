using MyFirstProgram.Models;
using System.Diagnostics;


namespace MyFirstProgram
{
    internal class GameEngine
    {
        internal void DivisionGame(string message)
        {
            var score = 0;

            Stopwatch timer = new Stopwatch();
            timer.Start();


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
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    timer.Stop();
                    string elapsedTime = String.Format("{0:00}:{1:00}", timer.Elapsed.Minutes, timer.Elapsed.Seconds);
                    Console.WriteLine($"Game over. Your final score is {score}. It took you {elapsedTime} to complete this game. Press any key to go back to the main menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void MultiplicationGame(string message)
        { 
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    timer.Stop();
                    string elapsedTime = String.Format("{0:00}:{1:00}", timer.Elapsed.Minutes, timer.Elapsed.Seconds);
                    Console.WriteLine($"Game over. Your final score is {score}. It took you {elapsedTime} to complete this game. Press any key to go back to the main menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void SubtractionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    timer.Stop();
                    string elapsedTime = String.Format("{0:00}:{1:00}", timer.Elapsed.Minutes, timer.Elapsed.Seconds);
                    Console.WriteLine($"Game over. Your final score is {score}. It took you {elapsedTime} to complete this game. Press any key to go back to the main menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void AdditionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            Stopwatch timer = new Stopwatch();
            timer.Start();


            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    timer.Stop();
                    string elapsedTime = String.Format("{0:00}:{1:00}", timer.Elapsed.Minutes, timer.Elapsed.Seconds);
                    Console.WriteLine($"Game over. Your final score is {score}. It took you {elapsedTime} to complete this game. Press any key to go back to the main menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }
    }
}
