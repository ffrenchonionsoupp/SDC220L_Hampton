/*******************************************************************
* Name: Francis Hampton
* Date: 3/22/26
* Assignment SDC220L Week 3 Project - Arrays and Lists
* Maths application (program) class.
* In this application, we will expand last week's calculator by adding a menu
* system, looping until the user quits, and supporting basic math operations 
* (add, subtract, divide, multiply) with classes and separate cs files.
*/
namespace CalculatorProject
{
    public class Maths
    {
        // note: these will do the math for us, keep an eye on formula
        public double Add(double intVal1, double intVal2)
        {
            return intVal1 + intVal2;
        }

        public double Subtract(double intVal1, double intVal2)
        {
            return intVal1 - intVal2;
        }

        public double Multiply(double intVal1, double intVal2)
        {
            return intVal1 * intVal2;
        }

        public double? Divide(double intVal1, double intVal2)
        {
            if (intVal2 == 0)
                return null;

            return intVal1 / intVal2;
        }

        public double? EvaluateFormula(string formula)
        {
            string[] parts = formula.Split(' ');

            if (parts.Length != 3)
                return null;

            double intVal1 = Convert.ToDouble(parts[0]);
            string operation = parts[1];
            double intVal2 = Convert.ToDouble(parts[2]);

            return operation switch
            {
                "+" => intVal1 + intVal2,
                "-" => intVal1 - intVal2,
                "*" => intVal1 * intVal2,
                "/" => intVal2 == 0 ? null : intVal1 / intVal2,
                _ => null
            };
        }
    }
}