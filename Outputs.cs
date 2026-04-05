/*******************************************************************
* Name: Francis Hampton
* Date: 4/5/26
* Assignment SDC220L Week 5 Project
* Outputs application (program) class.
* In this application, we will expand last week's calculator by adding a menu
* system, looping until the user quits, and supporting basic math operations 
* (add, subtract, divide, multiply) with classes and separate cs files.
*/
namespace CalculatorProject
{
    public class Outputs
    {
        // note: the following writelines will incorporate my planning from week 1 where 
        // I wanted to type out the logical equations and give little notes to make things personal!
        public void ShowResult(string operation, double result)
        {
            Console.WriteLine($"\nResult of {operation}: {result:F2}\n");
        }

        public void ShowValues(List<double> values)
        {
            Console.WriteLine("\nValues:");
            Console.WriteLine(string.Join(", ", values.Select(v => v.ToString("F2"))));
        }

        public void ShowError(string message)
        {
            Console.WriteLine($"\nError: {message}\n");
        }

        public void ShowingError(string message)
        {
            Console.WriteLine("\nOops! Looks like that didn't work! {0}", message);
        }
    }
}