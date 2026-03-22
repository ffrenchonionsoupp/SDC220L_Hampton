/*******************************************************************
* Name: Francis Hampton
* Date: 3/22/26
* Assignment SDC220L Week 3 Project - Arrays and Lists
* Inputs application (program) class.
* In this application, we will expand last week's calculator by adding a new menu
* system, looping until the user quits, and supporting basic math operations and memory actions
* with classes and separate cs files.
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

        public int GetInt(string prompt)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            return Convert.ToInt32(input);
        }

        public string? Formula()
        {
            Console.Write("Enter a formula (e.g., 6 - 9): ");
            return Console.ReadLine();
        }
    }
}