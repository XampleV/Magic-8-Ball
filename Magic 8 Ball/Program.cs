using System;

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
                string questionString = GetQuestionFromUser();
                int randomNumber = randomObject.Next(4);
                switch (randomNumber)
                {
                    case 0:
                        { 
                        Console.WriteLine("Yes.");
                        break;
                        }
                    case 1:
                        {
                            Console.WriteLine("No bro");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Bad idea");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("that's a mystery, no idea.");
                            break;
                        }
                }
            }
   
        }
    }
}
