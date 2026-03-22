/*******************************************************************
* Name: Francis Hampton
* Date: 3/22/26
* Assignment SDC220L Week 3 Project - Arrays and Lists
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
        public void ShowingAddition(double intVal1, double intVal2, double result)
        {
            Console.WriteLine(
                "\nTogether, the sum of {0} and {1} is {2}. Did you guess that too?",
                intVal1, intVal2, result);
        }

        public void ShowingSubtraction(double intVal1, double intVal2, double result)
        {
            Console.WriteLine(
                "\nTogether, the subtraction of {0} from {1} is {2}. What was your guess?",
                intVal2, intVal1, result);
        }

        public void ShowingMultiplication(double intVal1, double intVal2, double result)
        {
            Console.WriteLine(
                "\nWhen you multiply {0} by {1}, you get {2}. How far off were you?",
                intVal1, intVal2, result);
        }

        public void ShowingDivision(double intVal1, double intVal2, double result)
        {
            Console.WriteLine(
                "\nDividing {0} by {1} gives you {2}. Yippee! Math magic!",
                intVal1, intVal2, result);
        }

        public void ShowingFormulaResult(string formula, double result)
        {
            Console.WriteLine(
                "\nThe result of your formula \"{0}\" is {1}. Ain't that something?", formula, result);
        }

        public void ShowingSingleMemoryStored(double value)
        {
            Console.WriteLine($"\nAlright! I’ve tucked {value} safely into memory.");
        }

        public void ShowingSingleMemoryRetrieved(double value)
        {
            Console.WriteLine($"\nHere it is! Your stored value is {value}.");
        }

        public void ShowingSingleMemoryCleared()
        {
            Console.WriteLine("\nPoof! Your stored value has been cleared.");
        }

        public void ShowingCollectionValues(List<int> values)
        {
            Console.WriteLine("\nHere are all the values you're storing:");
            Console.WriteLine(string.Join(", ", values));
        }

        public void ShowingError(string message)
        {
            Console.WriteLine("\nOops! Looks like that didn't work! {0}", message);
        }
    }
}