/*******************************************************************
* Name: Francis Hampton
* Date: 3/15/26
* Assignment SDC220L Week 2 Project - Software Design and Control Statements
* Main application (program) class.
* In this application, we will expand last week's calculator by adding a menu
* system, looping until the user quits, and supporting basic math operations 
* (add, subtract, divide, multiply) with classes and separate cs files.
*/
namespace CalculatorProject
{
    public class CalculatorApp
    {
        static void Main(string[] args)
        {
            // note: setting up to call from other classes
            Messages msg = new Messages();
            Inputs input = new Inputs();
            Maths math = new Maths();
            Outputs output = new Outputs();

            // note: calling from the Messages class
            msg.PrintHeader();
            msg.PrintWelcome();

            // note: makes option nullable
            string? option = "";
            // note: while loop where option 6 is the trigger to stop
            while (option != "6")
            {
                // note: calling from the Messages class
                msg.PrintMenu();
                
                option = input.MenuChoice();
                Console.WriteLine();
            
                // switch case to perform actions based on option, set up for modules/methods
                switch (option)
                {
                    case "1":
                        double intVal1 = input.Numbers("Enter the first number: ");
                        double intVal2 = input.Numbers("Enter the second number: ");
                        double addResult = math.Add(intVal1, intVal2);
                        output.ShowingAddition(intVal1, intVal2, addResult);
                        break;

                    case "2":
                        intVal1 = input.Numbers("Enter the first number: ");
                        intVal2 = input.Numbers("Enter the second number: ");
                        double subResult = math.Subtract(intVal1, intVal2);
                        output.ShowingSubtraction(intVal1, intVal2, subResult);
                        break;

                    case "3":
                        intVal1 = input.Numbers("Enter the first number: ");
                        intVal2 = input.Numbers("Enter the second number: ");
                        double mulResult = math.Multiply(intVal1, intVal2);
                        output.ShowingMultiplication(intVal1, intVal2, mulResult);
                        break;

                    case "4":
                        intVal1 = input.Numbers("Enter the first number: ");
                        intVal2 = input.Numbers("Enter the second number: ");
                        double? divResult = math.Divide(intVal1, intVal2);

                        if (divResult == null)
                            output.ShowingError("Cannot divide by zero.");
                        else
                            output.ShowingDivision(intVal1, intVal2, divResult.Value);
                        break;

                    case "5":
                        string? formula = input.Formula();

                        if (formula == null)
                        {
                            output.ShowingError("No formula entered.");
                            break;
                        }
                        
                        double? formulaResult = math.EvaluateFormula(formula);

                        if (formulaResult == null)
                            output.ShowingError("Invalid formula.");
                        else
                            output.ShowingFormulaResult(formula, formulaResult.Value);
                        break;

                    case "6":
                        Console.WriteLine("Exiting calculator...one moment please!");
                        break;

                    default:
                        output.ShowingError("That was not a valid option! Please try again and choose 1–6.");
                        break;
                }
            }
        // note: calling from the Messages class 
        msg.PrintClosing();
        }
    }
}