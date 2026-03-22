/*******************************************************************
* Name: Francis Hampton
* Date: 3/22/26
* Assignment SDC220L Week 3 Project - Arrays and Lists
* Memories application (program) class.
* In this application, we will expand last week's calculator by adding a menu
* system, looping until the user quits, and supporting basic math operations 
* (add, subtract, divide, multiply) with classes and separate cs files.
*/
namespace CalculatorProject
{
    public class Memories
    {
        private double? singleValue = null;
        private List<int> collection = new List<int>();

        // Single value memory
        public void StoreSingleValue(double value) => singleValue = value;
        public double? GetSingleValue() => singleValue;
        public void ReplaceSingleValue(double value) => singleValue = value;
        public void ClearSingleValue() => singleValue = null;

        // Collection memory
        public bool AddToCollection(int value)
        {
            if (collection.Count >= 10)
                return false;

            collection.Add(value);
            return true;
        }

        public bool RemoveFromCollection(int value)
        {
            return collection.Remove(value);
        }

        public List<int> GetAllValues() => collection;

        public int GetCount() => collection.Count;

        public int GetSum() => collection.Sum();

        public double? GetAverage()
        {
            if (collection.Count == 0) return null;
            return collection.Average();
        }

        public int? GetFirstLastDifference()
        {
            if (collection.Count < 2) return null;
            return collection.First() - collection.Last();
        }
    }
}