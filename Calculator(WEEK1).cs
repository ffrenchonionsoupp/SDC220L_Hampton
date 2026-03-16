/*******************************************************************
* Name: Francis Hampton
* Date: 3/8/26
* Assignment SDC220L Week 1 Project - Calculator
* Main application (program) class.
* In this application, we will reate an application that will perform 
* some basic input and output operations.
*/

public class Calculate
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("\nFrancis - Week 1 Project\n");
        Console.WriteLine("Calculator 3.0!\n");

        // Print a welcome message (modularize in future?)
        Console.WriteLine("This is my calculator WIP. To use it, you");
        Console.WriteLine("will be prompted to enter values for both integers, floats,");
        Console.WriteLine("and they're operators. Once that information is given, this");
        Console.WriteLine("calculator will process the problem and output the answer.");
        Console.WriteLine("\nThis message is subject to change and develop as the calculator progresses.");

        // Performing integer operations (Addition)
        // Get 2 integer values from the user and add them together
        int intVal1 = 0;
        int intVal2 = 0;
        Console.Write("\nEnter an integer value: ");
        string? val = Console.ReadLine();
        intVal1 = Convert.ToInt32(val);
        Console.Write("Enter a second integer value: ");
        val = Console.ReadLine();
        intVal2 = Convert.ToInt32(val);
        int sum = intVal1 + intVal2;
        Console.WriteLine("\nTogether, the sum of {0:D} and {1:D} is {2:D}. Did you guess that too?",
            intVal1, intVal2, sum);

        // Performing float operations (Subtraction)
        // Get 2 floating-point values from the user and subtract them from one another
        Console.Write("\nEnter a floating point value: ");
        val = Console.ReadLine();
        double fltVal1 = Convert.ToDouble(val);
        Console.Write("Enter a second floating point value: ");
        val = Console.ReadLine();
        double fltVal2 = Convert.ToDouble(val);
        double reduction = fltVal1 - fltVal2;
        Console.WriteLine("\nTogether, the subtraction of {0:F2} from {1:F2} is {2:F2}. What was your guess?",
            fltVal1, fltVal2, reduction);

        // Print a closing message (modularize in future?)
        Console.WriteLine("\nThank you for testing my calculator. Be back soon!");
    }
}