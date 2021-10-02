using System;
using System.Collections.Generic;
namespace Test_HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Headder();
            string[] listwords = new string[3];
            listwords[0] = "Tennis";
            listwords[1] = "footbll";
            listwords[2] = "badminton";
            Random randGen = new Random();
            var resultRandom = randGen.Next(0,3);
            string Word = listwords[resultRandom];
        }

        // สร้าง
        static void Headder()
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Play game");
            Console.WriteLine("2. Exit");
            Console.Write("Please Select Menu: ");
            int number = int.Parse(Console.ReadLine());
            while (number > 3)
            {
                Console.ReadLine();
                number = int.Parse(Console.ReadLine());
            }
            if (number == 1)
            {
                Startgame();
            }
            else if (number == 2)
            {

            }

        }
        static void Startgame()
        {
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Incorrect Score: 0");
            Console.WriteLine("---------------------");
            Console.WriteLine("Input letter alphabet: ");
            Console.ReadLine();
            string Input = Console.ReadLine();
        }
        
    }
}