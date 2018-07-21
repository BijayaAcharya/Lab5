using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.WriteLine(" Welcome to Factorial Calculator");

                Console.WriteLine("Please enter a number between 1 to 10"); //asking user input

                int inPut = int.Parse(Console.ReadLine()); //storing input
          
                long factorial = 1; // declaring the long variable 

                for (int i = 1; i <= inPut; i++)
                {

                    factorial = factorial * i; // calculating the factorial

                    Console.WriteLine("The factorial of {0} is {1}", i , factorial); // printing the output
                }

                
                Console.WriteLine(" Do you want to continue?, 'y/n'"); // asking user input

                string asnwer = Console.ReadLine().ToLower(); // reading from the console and converting user input into lower case

                if (asnwer == "y")
                {
                }
                else
                {
                    break; // exit the program
                }
            }
        }
    }
}
