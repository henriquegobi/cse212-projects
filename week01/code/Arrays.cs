public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        //1. Create an array of doubles with the size of 'length'
        double[] results = new double[length];

        //2. Use a for loop to iterate from 0 to length - 1
        for (int i = 0; i < length; i++)
        {
            //3. In each iteration, calculate the multiple of 'number' by (i + 1) and put it on the array at index i
            results[i] = number * (i + 1);
        }
        //4. Return the array
        return results;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        //1. Get the count of elements in the list
        var count = data.Count;
        //2. Create a new list from the biggining to the amout index
        var bList = new List<int>(data.GetRange(0,amount));
        //3. Get the remaning elements from the amount index to the end of the List
        var eList = new List<int>(data.GetRange(amount, count - amount));
        // 4. Clearing the original List to replace its values
        data.Clear();
        // 5.Adding the first elements from the end to the bigginng from the orignal List
        data.AddRange(eList);
        // 6. Adding the remaining elements to the end of the new List
        data.AddRange(bList);
    }
}
