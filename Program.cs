using System;
using System.Linq;

public class DoubloonChecker
{
    public static bool IsDoubloon(string word)
    {
        // Convert the word to lowercase to make the check case-insensitive
        word = word.ToLower();

        // Group the characters by their occurrence and check if each group count is 2
        var groupedChars = word.GroupBy(c => c);

        // Return true if all characters appear exactly twice
        return groupedChars.All(g => g.Count() == 2);
    }

    public static void Main(string[] args)
    {
        // Example usage
        Console.WriteLine(IsDoubloon("Abba"));   // True
        Console.WriteLine(IsDoubloon("deed"));   // True
        Console.WriteLine(IsDoubloon("Hello"));  // False
    }
}
