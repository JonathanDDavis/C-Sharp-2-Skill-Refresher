using System;

namespace C_Sharp_Refresher
{
    class Program
    {
        static void Main(string[] args)
        {
            Player.greeting();
            Player.counting();
        }
    }

    class Player
    {
        public static void greeting()
        {
            string sex = "";
            string test = "";
            Console.WriteLine("Hello to my program! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age? Please enter a number");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your sex? Please type in M or F.");
            test = Console.ReadLine().ToUpper();
            if (test == "M")
            {
                sex = "male";
            }
            else if (test == "F")
            {
                sex = "female";
            }
            else
            {
                Console.WriteLine("Sorry the is incorrect");
            }

            Console.WriteLine("Are you ready to start counting?");

            Console.WriteLine("Hello " + name + "! You are a " + sex + " and you are " + age +
                              ".");
            Console.ReadLine();
        }

        public static void counting()
        {
            Console.WriteLine("I will count all even numbers in between 1 and 50.");
            Console.ReadLine();
            int i = 0;
            while (i < 50)
            {
                Console.WriteLine(i += 2); 

            }
        }
    }

}