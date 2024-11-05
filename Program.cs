using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for a number input to perform math operations on
            Console.Write("Enter a number to perform math operations: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the MathOperations class to call its methods
            MathOperations mathOps = new MathOperations();

            // Call the AddFive method and display the result
            int resultAdd = mathOps.AddFive(userInput);
            Console.WriteLine("Adding 5 to your number gives: " + resultAdd);

            // Call the MultiplyByTwo method and display the result
            int resultMultiply = mathOps.MultiplyByTwo(userInput);
            Console.WriteLine("Multiplying your number by 2 gives: " + resultMultiply);

            // Call the SubtractTen method and display the result
            int resultSubtract = mathOps.SubtractTen(userInput);
            Console.WriteLine("Subtracting 10 from your number gives: " + resultSubtract);

            // Keep console open until user closes
            Console.ReadLine();
        }
    }
}