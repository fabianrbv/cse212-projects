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
        // Step 1: Create an array with the required length.
        double[] result = new double[length];

        // Step 2: Use a loop to fill the array with multiples of the number.
        // The first value should be number * 1, then number * 2, etc.
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        // Step 3: Return the completed array.
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
        // Step 1: Calculate the index where the rotation should start.
        int startIndex = data.Count - amount;

        // Step 2: Create a temporary list to store the rotated elements.
        List<int> temp = new List<int>();

        // Step 3: Add the elements from the start index to the end of the list.
        for (int i = startIndex; i < data.Count; i++)
        {
            temp.Add(data[i]);
        }

        // Step 4: Add the elements from the beginning of the list to the start index.
        for (int i = 0; i < startIndex; i++)
        {
            temp.Add(data[i]);
        }

        // Step 5: Clear the original list and add all elements from the temporary list.
        data.Clear();
        data.AddRange(temp);
    }
}
