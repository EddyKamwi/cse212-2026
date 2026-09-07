public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting
    /// with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}. Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //1- create an array to hold the multiples of size length-parameter
        double[] multiples = new double[length];
        //2- using a for loop, iterate less than length-parameter and 
        for (int i = 0; i < length; i++)
        {
            //3- for each iteration, append the number-parameter, multiplying
            // the number by the addition of its index and 1
            multiples[i] = number * (i + 1);
        }
        //4-then after the loop is done, return the which was created in step 1 array.

        return multiples; // replace this return statement with your own
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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //1-create a loop that will eterate for [int amount] time
        for (int i = 0; i < amount; i++)
        {
            // 2- for each eteration get the last element of the list 
            int lastElementIndex = data.Count - 1;
            int lastElement = data[lastElementIndex];
            // 3- insert the element in step 2 at the beginning of the list
            data.Insert(0, lastElement);
            // 4- delete the last element to avoid dublication of the element.
            data.RemoveAt(lastElementIndex);
        }

    }
}
