/*******************************************************************
* Name: Francis Hampton
* Date: 4/5/26
* Assignment SDC220L Week 5 Project
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
             while (true)
            {
                try
                {
                    Console.Write(prompt);
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Oops! That's an invalid number. Try again.\n");
                }
            }
        }

        public List<double> GetNumberList()
        {
            Console.WriteLine("Enter numbers separated by spaces:");

            while (true)
            {
                try
                {
                    string? input = Console.ReadLine();
                    return input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Oops! That's an invalid list. Try again.\n");
                }
            }
        }

        public string? Formula()
        {
            Console.Write("Enter a formula (e.g., 6 - 9): ");
            return Console.ReadLine();
        }
    }
}