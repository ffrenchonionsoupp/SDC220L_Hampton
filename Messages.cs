/*******************************************************************
* Name: Francis Hampton
* Date: 4/5/26
* Assignment SDC220L Week 5 Project
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
            Console.WriteLine("\nFrancis - Final Calculator Application\n");
            Console.WriteLine("Calculator 5.0!\n");
        }

        public void PrintWelcome()
        {
            // Print a welcome message
            Console.WriteLine("This is my calculator app for week 5!");
            Console.WriteLine("The calculator will run until you tell it to stop. Have fun!");
            Console.WriteLine("I hope you will enjoy using my application :)\n");
        }
        public void PrintMainMenu()
        {
            // Print a menu of options
            Console.WriteLine("\n ******* Main Menu *******\n");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Memory Options");
            Console.WriteLine("6. Quit!");
            Console.Write("\nSelect an option (1-6): ");
        }
        public void PrintMemoryMenu()
        {
            // Print a menu of options
            Console.WriteLine("\n ******* Memory Menu *******\n");
            Console.WriteLine("1. Store a value");
            Console.WriteLine("2. View all stored values");
            Console.WriteLine("3. Clear a value");
            Console.WriteLine("4. Clear all memory");
            Console.WriteLine("5. Return to Main Menu");
            Console.Write("\nSelect an option (1-5): ");
        }
        public void PrintInvalidChoice()
        {
            Console.WriteLine("Uh-oh! Invalid choice. Try again.\n");
        }
        public void PrintDivideByZero()
        {
            Console.WriteLine("That's silly! You cannot divide by zero.\n");
        }
        public void PrintClosing()
        {
            // Print a closing message
            Console.WriteLine("\nThank you for testing my calculator. Be back soon!");
        }
    }
}