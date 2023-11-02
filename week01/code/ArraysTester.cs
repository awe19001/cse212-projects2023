public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume 45reeeeed length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
 
  /*  private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return new double[0]; // replace this return statement with your own
    }
   */ 

 private static double[] MultiplesOf(double number, int length)      
    {
        List<double> multiples = new List<double>();                    //step1: We start by creating a 'List<double>' called 'multiples' to store the calculated multiples of the given number.
        for (int i = 1; i <= length; i++)                               //step2: We use a for loop to iterate from 1 to the specified length. It's important to start the loop from 1 to calculate multiples correctly.
        {
            double multiple = number * i;                               //step3: Inside the loop, we calculate the multiple of the number by the loop counter i, and we add this value to the multiples list.
            multiples.Add(multiple);
        }
        return multiples.ToArray();                                     //step4: Convert the list to a double array and return it as the result of the function.        
    } 



    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
/*
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

    }
}
*/

private static void RotateListRight(List<int> data, int amount) //here is the implementation of the 'RotateListRight' funtion
{
    if (amount < 1 || amount > data.Count)                      //step1: Check if the given 'amount' is within a valid range.
    {
                                                                //Handle invalid input range or return an error.
        return;
    }

    int rotateIndex = data.Count - amount;                      //step2. Calculate the index at which rotation needs to happen based on 'amount'. This can be done by subracting the 'amount' from 'data.Count'.

    List<int> temp = data.GetRange(0, rotateIndex);             //step3: Create a temporary list to hold the elements that need to be rotated.
    data.RemoveRange(0, rotateIndex);                           //step4: Remove the elements that will be rotated from the original list.
    data.InsertRange(data.Count, temp);                         //step5: Add the elements from the temporary list to the beginnning of the original list to complete the rotation.
}
}                                                               