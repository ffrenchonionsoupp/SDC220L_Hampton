/*******************************************************************
* Name: Francis Hampton
* Date: 3/15/26
* Assignment SDC220L Week 2 Project - Software Design and Control Statements
* Inputs application (program) class.
* In this application, we will expand last week's calculator by adding a menu
* system, looping until the user quits, and supporting basic math operations 
* (add, subtract, divide, multiply) with classes and separate cs files.
*/
namespace CalculatorProject
{
    public class Inputs
    {
        public string? MenuChoice()
        {
            return Console.ReadLine();
        }

        public double Numbers(string prompt)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            return Convert.ToDouble(input);
        }

        public string? Formula()
        {
            Console.Write("Enter a formula (e.g., 6 - 9): ");
            return Console.ReadLine();
        }
    }
}