using System;
 
class Program
{
    static void Main(string[] args)
    {
        // Declare variables to store the numbers to be added
        int number1 = 2;
        int number2 = 1;
        int sub;
 
        sub = number1 - number2;
 
        // Display the result
        Console.WriteLine("The sub of {0} and {1} is {2}", number1, number2, sub);
 
        // Keep the console window open until a key is pressed
        Console.ReadKey();
    }
}
