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
        // Student notes:
        // Create array of multiples
        // Example: 3,5 -> {3,6,9,12,15}
        // Use loop: multiples[i] = number * (i+1)

        var multiples = new List<double>();
        for (int i = 1; i <= length; i++)
        {
            multiples.Add(number * i);
        }
        return multiples.ToArray();
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
        // Student notes:
        // Rotate list right by amount
        // Example: {1,2,3,4,5,6,7,8,9} amount 3 -> {7,8,9,1,2,3,4,5,6}
        // Use modulo to wrap indices

        var rotated = new List<int>();
        for (int i = 0; i < data.Count; i++)
        {
            int originalIndex = (i - amount + data.Count) % data.Count;
            rotated.Add(data[originalIndex]);
        }
        data.Clear();
        data.AddRange(rotated);
    }
}
