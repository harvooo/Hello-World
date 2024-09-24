using System;
using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Week1
{

    class Program
    {
        static void Main(string[] args)
        {
            Task5();
        }

        static void Task1()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + ". You will be 30 in " + (30 - age) + " years."); 
        }

        static void Task2()
        {
            // a child is younger than 13, a teenager is between 13 and 19, and an adult is older than 19. And the oldest person should be less than 110.
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            if (age <= 0 || age >= 110) {
                Console.WriteLine("Invalid Age!");
            } 
            else if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else if (age >= 13 || age <= 19)
            {
                Console.WriteLine("You are a teenager");
            }
            else if (age > 19)
            {
                Console.WriteLine("You are an adult");   
            }
        }

        static void Task3()
        {
            Console.WriteLine("Please enter a number: ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i < 0)
            {
                Console.WriteLine("Is negative");
            }
            else if (i > 0)
            {
                Console.WriteLine("Is positive");
            } else
            {
                Console.WriteLine("Is zero");
            }
            
            
        }

        static void Task4()
        {
            Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0) && !(year % 100 == 0))
            {
                Console.WriteLine("Leap year!");
            }
            else
            {
                Console.WriteLine("Not leap year!");
            }
        }

        static void Task5()
        {
            Console.WriteLine("Enter a number: ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("Number is even!");
            } else
            {
                Console.WriteLine("Number is odd!");
            }
        }
    }
}
