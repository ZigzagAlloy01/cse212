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
        //1. Create a double[] called result with "length" as size (written inside the [] in new double)
        double[] result = new double[length];
        //2. Fill the array with multiples of number, using a for loop and i+1
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result; 
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
        //1. We use amount and we calculate the rotation using %= and data.Count
        amount %= data.Count;
        //2. We divide the list in 2, using .GetRange (and the name of the list)
        List<int> lastPart = data.GetRange(data.Count - amount, amount);
        List<int> firstPart = data.GetRange(0, data.Count - amount); 
        //3. We clear the original "List<int> data", and we add the first and last part in the proper range, using .AddRange and the new Lists
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
