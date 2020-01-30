//Programmer: Shane Scallon
//Date: 1/29/2020
//Description: C# console that demonstrates the use of conditional statements
//after getting input from users
using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for input
            Console.WriteLine("Please enter expected grade number");

            //use try-catch to validate the user input
            //If the user enters wrong input the catch will handle and show error message
            try
            {
                //input variable gathers input from user
                string input = Console.ReadLine();
                //Variable stores grade after input value is parsed to an interger
                int grade = int.Parse(input);

                //if else-if statement that determines the students letter grade based on 
                //the interger grade they entered
                if (grade > 97 && grade <= 100)
                {
                    Console.WriteLine("A+");
                }
                else if (grade > 91 && grade < 98)
                {
                    Console.WriteLine("A");
                }
                else if (grade > 89 && grade < 92)
                {
                    Console.WriteLine("A-");
                }
                else if (grade > 87 && grade < 90)
                {
                    Console.WriteLine("B+");
                }
                else if (grade > 81 && grade < 88)
                {
                    Console.Write("B");
                }
                else if (grade > 79 && grade < 82)
                {
                    Console.WriteLine("B-");
                }
                else if (grade > 77 && grade < 80)
                {
                    Console.WriteLine("C+");
                }
                else if (grade > 71 && grade <78)
                {
                    Console.WriteLine("C");
                }
                else if (grade > 69 && grade < 72)
                {
                    Console.WriteLine("C-");
                }
                else if (grade > 67 && grade < 70)
                {
                    Console.WriteLine("D+");
                }
                else if (grade > 61 && grade <68)
                {
                    Console.WriteLine("D");
                }
                else if (grade > 59 && grade < 62)
                {
                    Console.WriteLine("D-");
                }
                else if (grade < 60 && grade >= 0)
                {
                    Console.WriteLine("F");
                }
                else
                {
                    Console.WriteLine("Please try again and enter a valid grade number between 1 and 100");
                }

            }//end of try
            catch
            {
                Console.WriteLine("Please enter an interger value");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
                
            }//end of catch
        }
    }
}
