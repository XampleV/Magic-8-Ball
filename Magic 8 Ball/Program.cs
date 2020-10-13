using System;
using System.Threading;
namespace Magic_8_Ball
{
    class Program
    {
        
        static Random randomObject = new Random();
        static void Main(string[] args)
        {
            QuestionLoop();
        }
        static string GetQuestionFromUser()
        {
            Console.Write("What question do you have? ");
            string questionString = Console.ReadLine();
            return questionString;
        }
        static void QuestionLoop()
        {
            while (true)
            {
                int numberOfSecondToSleep = randomObject.Next((5) + 1);
                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                string questionString = GetQuestionFromUser();
                if (questionString.ToLower() == "quit")
                {
                    break;
                }
                if (questionString.ToLower() == "google")
                {
                    Console.WriteLine("We don't speak of that person, they dont answer well.");
                    break;
                }
                Console.WriteLine("Hmmm, let me think...  one sec, brb.");
                Thread.Sleep(numberOfSecondToSleep * 1000);
                int randomNumber = randomObject.Next(10);
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("Yes.");
                        break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("No bro");
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("Bad idea");
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("that's a mystery, no idea.");
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("Maybe");
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("No, go grab a coffee");
                            break;
                        }
                    case 6:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("Are you really asking a program to decide what to do? Yes, that's a good idea.");
                            break;
                        }
                    case 7:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("This answer had a %10 chance to be picked, did you know that? By the way, not gonna answer your question.");
                            break;
                        }
                    case 8:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("I'm trying to think of what to write here... I have no idea.");
                            break;
                        }
                    case 9:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("Interesting, go ask someone else, I'm busy. You literally have google.");
                            break;
                        }
                    case 10:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                            Console.WriteLine("Number 10 is the answer to your question.");
                            break;
                        }
                }
            }
   
        }
    }
}
