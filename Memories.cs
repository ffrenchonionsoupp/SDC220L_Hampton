/*******************************************************************
* Name: Francis Hampton
* Date: 4/5/26
* Assignment SDC220L Week 5 Project
* Memories application (program) class.
* In this application, we will expand last week's calculator by adding a menu
* system, looping until the user quits, and supporting basic math operations 
* (add, subtract, divide, multiply) with classes and separate cs files.
*/
namespace CalculatorProject
{
    public class Memories
    {
        // Single-value memory
        private double? singleValue = null;
        public void StoreSingleValue(double value)
        {
            singleValue = value;
            Console.WriteLine($"\nOkay! I stored {value:F2} as your single memory value.\n");
        }
        public double? GetSingleValue()
        {
            return singleValue;
        }
        public void ReplaceSingleValue(double value)
        {
            singleValue = value;
            Console.WriteLine($"\nAlrighty! The single memory value with {value:F2} has been replaced.\n");
        }
        public void ClearSingleValue()
        {
            singleValue = null;
            Console.WriteLine("\nAll done! The single memory value cleared.\n");
        }

        // Collection memory (up to 10 integers)
        private List<int> collection = new List<int>();

        // Collection Memory Operations
        public bool AddToCollection(int value)
        {
            if (collection.Count >= 10)
            {
                Console.WriteLine("Sorry! The memory is full. The ten-value limit has been reached!\n");
                return false;
            }
            collection.Add(value);
            Console.WriteLine($"You got it! Stored {value:F2} in memory.\n");
            return true;
        }
        public bool RemoveFromCollection(int value)
        {
            return collection.Remove(value);
        }
        public void ClearCollection()
        {
            collection.Clear();
        }
        public List<int> GetAllValues()
        {
            return collection;
        }
        public int GetCount()
        {
            return collection.Count;
        }
        public int GetSum()
        {
            return collection.Sum();
        }
        public double? GetAverage()
        {
            if (collection.Count == 0)
                return null;

            return collection.Average();
        }
        public int? GetFirstLastDifference()
        {
            if (collection.Count < 2)
                return null;

            return collection.First() - collection.Last();
        }
    }
}