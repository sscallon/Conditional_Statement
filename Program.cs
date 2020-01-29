using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for input
            Console.WriteLine("Please enter grade number");

            //use try-catch to validate the user input
            //If the user enters wrong input the catch will handle and show error message
            try
            {
                //input variable gathers input from user
                string input = Console.ReadLine();
                //
                int Grade = int.Parse(input);






            }
            catch
            {
                Console.WriteLine("Please enter an interger value");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
                
            }
        }
    }
}
