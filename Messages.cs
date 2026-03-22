/*******************************************************************
* Name: Francis Hampton
* Date: 3/22/26
* Assignment SDC220L Week 3 Project - Arrays and Lists
* Messages application (program) class.
* In this application, we will expand last week's calculator by adding a new menu
* system, looping until the user quits, and supporting basic math operations and memory actions
* with classes and separate cs files.
*/
namespace CalculatorProject
{
    public class Messages
    {
        public void PrintHeader()
        {
            // Print a header line
            Console.WriteLine("\nFrancis - Week 3 Project\n");
            Console.WriteLine("Calculator 3.0!\n");
        }

        public void PrintWelcome()
        {
            // Print a welcome message
            Console.WriteLine("This is my calculator app WIP for week 3!");
            Console.WriteLine("This week, you can complete all the actions from last week, while also .");
            Console.WriteLine("being able to store values in memory. You can still decide to add, ");
            Console.WriteLine("subtract, multiply, divide, or even submit your own formula! You can also ");
            Console.WriteLine("work with a collection of up to 10 integers.");
            Console.WriteLine("The calculator will run until you tell it to stop. Enjoy!");
            Console.WriteLine("This message is subject to change and develop as the calculator progresses.");
        }
        public void PrintMainMenu()
        {
            // Print a menu of options
            Console.WriteLine("\n ******* Main Menu *******\n");
            Console.WriteLine("1. Fun time with Math!");
            Console.WriteLine("2. Single Memory values");
            Console.WriteLine("3. Memory Collection (ONLY 10 integers)");
            Console.WriteLine("4. Quit!");
            Console.Write("\nSelect an option (1-4): ");
        }
        public void PrintMathMenu()
        {
            // Print a menu of options
            Console.WriteLine("\n ******* Math Menu *******\n");
            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Subtract two numbers");
            Console.WriteLine("3. Multiply two numbers");
            Console.WriteLine("4. Divide two numbers");
            Console.WriteLine("5. Enter a formula");
            Console.WriteLine("6. Return to Main Menu");
            Console.Write("\nSelect an option (1-6): ");
        }
        public void PrintSingleMemoryMenu()
        {
            // Print a menu of options
            Console.WriteLine("\n ******* Single Memory Menu *******\n");
            Console.WriteLine("1. Store value");
            Console.WriteLine("2. Retrieve value");
            Console.WriteLine("3. Replace value");
            Console.WriteLine("4. Clear value");
            Console.WriteLine("5. Return to Main Menu");
            Console.Write("\nSelect an option (1-5): ");
        }
        public void PrintCollectionMenu()
        {
            // Print a menu of options
            Console.WriteLine("\n ******* Mermory Collection Menu *******\n");
            Console.WriteLine("1. Add a value");
            Console.WriteLine("2. Remove a value");
            Console.WriteLine("3. Display all values");
            Console.WriteLine("4. Display counts");
            Console.WriteLine("5. Sum of values");
            Console.WriteLine("6. Average of values");
            Console.WriteLine("7. Difference of values");
            Console.WriteLine("8. Return to Main Menu");
            Console.Write("\nSelect an option (1-8): ");
        }

        public void PrintClosing()
        {
            // Print a closing message
            Console.WriteLine("\nThank you for testing my calculator. Be back soon!");
        }
    }
}