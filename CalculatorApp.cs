/*******************************************************************
* Name: Francis Hampton
* Date: 3/22/26
* Assignment SDC220L Week 3 Project - Arrays and Lists
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
            Memories memory = new Memories();

            // note: calling from the Messages class
            msg.PrintHeader();
            msg.PrintWelcome();

            // note: makes option nullable
            string? option = "";

            // Main Menu
            // note: while loop where option 4 is the trigger to stop
            while (option != "4")
            {
                // note: calling from the Messages class
                msg.PrintMainMenu();
                option = input.MenuChoice();
                Console.WriteLine();

                // switch case to perform actions based on option, set up for modules/methods
                switch (option)
                {
                    case "1":
                        RunMathMenu(msg, input, math, output);
                        break;

                    case "2":
                        RunSingleMemoryMenu(msg, input, math, output, memory);
                        break;

                    case "3":
                        RunCollectionMenu(msg, input, output, memory);
                        break;

                    case "4":
                        break;

                    default:
                        output.ShowingError("Invalid selection. Please choose 1–4.");
                        break;
                }
            }

            msg.PrintClosing();

            // Math Menu
            static void RunMathMenu(Messages msg, Inputs input, Maths math, Outputs output)
            {
                string? choice = "";

                // note: while loop where option 6 is the trigger to stop
                while (choice != "6")
                {
                    // note: calling from the Messages class
                    msg.PrintMathMenu();
                    
                    choice = input.MenuChoice();
                    Console.WriteLine();
                
                    // switch case to perform actions based on option, set up for modules/methods
                    switch (choice)
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
            }

            // Single Memory Menu
            static void RunSingleMemoryMenu(Messages msg, Inputs input, Maths math, Outputs output, Memories memory)
            {
                string? choice = "";

                // note: while loop where option 5 is the trigger to stop
                while (choice != "5")
                {
                    // note: calling from the Messages class
                    msg.PrintSingleMemoryMenu();

                    choice = input.MenuChoice();
                    Console.WriteLine();

                    // switch case to perform actions based on option, set up for modules/methods
                    switch (choice)
                    {
                        case "1":
                            double val = input.Numbers("Enter a value to store: ");
                            memory.StoreSingleValue(val);
                            output.ShowingSingleMemoryStored(val);
                            break;

                        case "2":
                            double? stored = memory.GetSingleValue();
                            if (stored == null)
                                output.ShowingError("No value stored yet.");
                            else
                                output.ShowingSingleMemoryRetrieved(stored.Value);
                            break;

                        case "3":
                            double newVal = input.Numbers("Enter a new value to replace the old one: ");
                            memory.ReplaceSingleValue(newVal);
                            output.ShowingSingleMemoryStored(newVal);
                            break;

                        case "4":
                            memory.ClearSingleValue();
                            output.ShowingSingleMemoryCleared();
                            break;

                        case "5":
                            break;

                        default:
                            output.ShowingError("Invalid selection.");
                            break;
                    }
                }
            }

            // Collection Memory Menu
            static void RunCollectionMenu(Messages msg, Inputs input, Outputs output, Memories memory)
            {
                string? choice = "";

                // note: while loop where option 8 is the trigger to stop
                while (choice != "8")
                {
                    msg.PrintCollectionMenu();
                    choice = input.MenuChoice();
                    Console.WriteLine();

                    // switch case to perform actions based on option, set up for modules/methods
                    switch (choice)
                    {
                        case "1":
                            int addVal = input.GetInt("Enter an integer to add: ");
                            if (!memory.AddToCollection(addVal))
                                output.ShowingError("Collection is full (max 10 values).");
                            else
                                Console.WriteLine($"\nAdded {addVal} to your collection!");
                            break;

                        case "2":
                            int removeVal = input.GetInt("Enter a value to remove: ");
                            if (!memory.RemoveFromCollection(removeVal))
                                output.ShowingError("That value is not in your collection.");
                            else
                                Console.WriteLine($"\nRemoved {removeVal} from your collection!");
                            break;

                        case "3":
                            var values = memory.GetAllValues();
                            if (values.Count == 0)
                                output.ShowingError("Your collection is empty.");
                            else
                                output.ShowingCollectionValues(values);
                            break;

                        case "4":
                            Console.WriteLine($"\nYou are storing {memory.GetCount()} values.");
                            break;

                        case "5":
                            Console.WriteLine($"\nThe sum of your values is {memory.GetSum()}.");
                            break;

                        case "6":
                            double? avg = memory.GetAverage();
                            if (avg == null)
                                output.ShowingError("Cannot average an empty collection.");
                            else
                                Console.WriteLine($"\nThe average of your values is {avg}.");
                            break;

                        case "7":
                            int? diff = memory.GetFirstLastDifference();
                            if (diff == null)
                                output.ShowingError("Need at least two values to compute a difference.");
                            else
                                Console.WriteLine($"\nThe difference between the first and last values is {diff}.");
                            break;

                        case "8":
                            break;

                        default:
                            output.ShowingError("Invalid selection.");
                            break;
                    }
                }
            }
        }
    }
}