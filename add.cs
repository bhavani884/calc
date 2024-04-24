using System;
 
class Program
{
    static void Main(string[] args)
    {
        // Declare variables to store the numbers to be added
        int number1 = 1;
        int number2 = 2;
        int sum;
 
        sum = number1 + number2;
 
        // Display the result
        Console.WriteLine("The sum of {0} and {1} is {2}", number1, number2, sum);
 
        // Keep the console window open until a key is pressed
        Console.ReadKey();
    }
}
