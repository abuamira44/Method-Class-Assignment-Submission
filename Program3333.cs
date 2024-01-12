using System;

// Create a class called MathOperations
public class MathOperations
{
    // Create a void method that takes two integers as parameters
    public void PerformMathOperation(int firstNumber, int secondNumber)
    {
        // Do a math operation on the first integer (e.g., add 10) and display the second integer to the screen
        int result = firstNumber + 10;
        Console.WriteLine($"Math operation result: {result}, Displayed number: {secondNumber}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathOperations = new MathOperations();

        // Call the method in the class, passing in two numbers (e.g., 5 and 20)
        mathOperations.PerformMathOperation(5, 20);

        // Call the method in the class, specifying the parameters by name
        mathOperations.PerformMathOperation(firstNumber: 8, secondNumber: 15);
    }
}


