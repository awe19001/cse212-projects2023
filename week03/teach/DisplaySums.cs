/*
 * CSE212 
 * (c) BYU-Idaho
 * 05-Teach - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class DisplaySums
{
    public static void Run()
    {
        DisplaySumPairs(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        // Should show something like (order does not matter):
        // 6 4
        // 7 3
        // 8 2
        // 9 1 

        Console.WriteLine("------------");
        DisplaySumPairs(new[] { -20, -15, -10, -5, 0, 5, 10, 15, 20 });
        // Should show something like (order does not matter):
        // 10 0
        // 15 -5
        // 20 -10

        Console.WriteLine("------------");
        DisplaySumPairs(new[] { 5, 11, 2, -4, 6, 8, -1 });
        // Should show something like (order does not matter):
        // 8 2
        // -1 11
    }

    /// <summary>
    /// Display pairs of numbers (no duplicates should be displayed) that sum to
    /// 10 using a set in O(n) time. We are assuming that there are no duplicates
    /// in the list.
    /// </summary>
    /// <param name="numbers">array of integers</param>
    private static void DisplaySumPairs(int[] numbers)
    {
        // Use a HashSet to keep track of seen numbers
        HashSet<int> seenNumbers = new HashSet<int>();

        // Iterate through each number in the array
        foreach (var num in numbers)
        {
            // Calculate the complement needed for the sum to be 10
            int complement = 10 - num;

            // Check if the complement is in the HashSet
            if (seenNumbers.Contains(complement))
            {
                // Display the pair
                Console.WriteLine($"{num} {complement}");
            }

            // Add the current number to the HashSet
            seenNumbers.Add(num);
        }
    }
}