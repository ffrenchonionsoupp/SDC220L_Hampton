/*******************************************************************
* Name: Francis Hampton
* Date: 4/5/26
* Assignment SDC220L Week 5 Project
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
        public double Add(List<double> nums)
        {
            return nums.Sum();
        }

        public double Subtract(List<double> nums)
        {
            double result = nums[0];
            for (int i = 1; i < nums.Count; i++)
                result -= nums[i];
            return result;
        }

        public double Multiply(List<double> nums)
        {
            double result = 1;
            foreach (double n in nums)
                result *= n;
            return result;
        }

        public double Divide(List<double> nums)
        {
            double result = nums[0];

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");

                result /= nums[i];
            }

            return result;
        }
    }
}