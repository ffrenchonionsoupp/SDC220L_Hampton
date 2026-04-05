/*******************************************************************
* Name: Francis Hampton
* Date: 4/5/26
* Assignment SDC220L Week 5 Project
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
            while (option != "6")
            {
                // note: calling from the Messages class
                msg.PrintMainMenu();
                option = input.MenuChoice();
                Console.WriteLine();

                // switch case to perform actions based on option, set up for modules/methods
                switch (option)
                {
                    case "1":
                        RunMathOperation("Add", math, input, output);
                        break;

                    case "2":
                        RunMathOperation("Subtract", math, input, output);
                        break;

                    case "3":
                        RunMathOperation("Multiply", math, input, output);
                        break;

                    case "4":
                        RunMathOperation("Divide", math, input, output);
                        break;

                    case "5":
                        RunMemoryMenu(msg, input, memory, output);
                        break;

                    case "6":
                        Console.WriteLine("Exiting calculator...one moment please!");
                        break;

                    default:
                        msg.PrintInvalidChoice();
                        break;
                }
            }

            msg.PrintClosing();
        }
        // Math operations for multi-numbers
        static void RunMathOperation(string operation, Maths math, Inputs input, Outputs output)
        {
            try
            {
                List<double> nums = input.GetNumberList();

                if (nums.Count == 0)
                {
                    output.ShowingError("No numbers entered.");
                    return;
                }

                double result = operation switch
                {
                    "Add" => math.Add(nums),
                    "Subtract" => math.Subtract(nums),
                    "Multiply" => math.Multiply(nums),
                    "Divide" => math.Divide(nums),
                    _ => 0
                };
                output.ShowResult(operation, result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
                output.ShowingError("Cannot divide by zero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                output.ShowingError("An error occurred while performing the operation.");
            }
        }
        // Memory Menu (note: combines single memory and collection menus)
        static void RunMemoryMenu(Messages msg, Inputs input, Memories memory, Outputs output)
        {
            string? choice = "";

            while (choice != "5")
            {
                msg.PrintMemoryMenu();
                choice = input.MenuChoice();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        // note: storing a value in memory
                        double val = input.Numbers("Enter a value to store: ");
                        memory.AddToCollection((int)val); // memory stores ints
                        break;

                    case "2":
                        // note: showing all stored values
                        var values = memory.GetAllValues();
                        if (values.Count == 0)
                            output.ShowingError("Your memory is empty!");
                        else
                            output.ShowValues(values.Select(v => (double)v).ToList());
                        break;

                    case "3":
                        // note: clearing a value from memory
                        double removeDouble = input.Numbers("Enter a value to remove: ");

                        // note: ensure the user entered a whole number
                        if (removeDouble % 1 != 0)
                        {
                            output.ShowingError("Please enter a whole number (memory stores integers only).");
                            break;
                        }

                        int removeVal = (int)removeDouble;

                        if (!memory.RemoveFromCollection(removeVal))
                            output.ShowingError("That value is not in your collection.");
                        else
                            Console.WriteLine($"\nRemoved {removeVal} from your collection! Poof!");
                        break;

                    case "4":
                        // note: clearing memory
                        memory.ClearCollection();
                        Console.WriteLine("Poof! Your memory has been cleared.\n");
                        break;

                    case "5":
                        break;

                    default:
                        output.ShowingError("Invalid selection. Please choose 1–4.");
                        break;
                }
            }
        }
    }
}