/*******************************************************************
* Name: Francis Hampton
* Date: 3/15/26
* Assignment SDC220L Week 2 Project - Software Design and Control Statements
* Messages application (program) class.
* In this application, we will expand last week's calculator by adding a menu
* system, looping until the user quits, and supporting basic math operations 
* (add, subtract, divide, multiply) with classes and separate cs files.
*/
namespace CalculatorProject
{
    public class Messages
    {
        public void PrintHeader()
        {
            // Print a header line
            Console.WriteLine("\nFrancis - Week 2 Project\n");
            Console.WriteLine("Calculator 2.0!\n");
        }

        public void PrintWelcome()
        {
            // Print a welcome message
            Console.WriteLine("This is my calculator app WIP for week 2!");
            Console.WriteLine("This week, you will be prompted to choose an operation from the list below.");
            Console.WriteLine("You can decide to add, subtract, multiply, divide, or even submit your own formula!");
            Console.WriteLine("The calculator will run until you tell it to stop. Enjoy!");
            Console.WriteLine("\nThis message is subject to change and develop as the calculator progresses.");
        }

        public void PrintMenu()
        {
            // Print a menu of options
            Console.WriteLine("\n ******* Calculator Menu *******\n");
            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Subtract two numbers");
            Console.WriteLine("3. Multiply two numbers");
            Console.WriteLine("4. Divide two numbers");
            Console.WriteLine("5. Enter a formula");
            Console.WriteLine("6. Quit");
            Console.Write("\nSelect an option (1-6): ");
        }

        public void PrintClosing()
        {
            // Print a closing message
            Console.WriteLine("\nThank you for testing my calculator. Be back soon!");
        }
    }
}