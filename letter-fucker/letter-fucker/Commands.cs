namespace letter_fucker;

using CommandDotNet;
using CommandDotNet.Rendering;

public class Commands
{
    // Main function: "Count".
    // Counts individual letters and their frequency in given text. It is NOT case-sensitive.
    [Command(Description = "Counts the frequency of letters in a text.",
        UsageLines = new[]
        {
            "Count [source file path] (txt)",
            "%AppName% %CmdPath% file.txt"
        },
        ExtendedHelpTextLines = new[]
        {
            "%AppName% %CmdPath% file.txt",
            "Example: letter-fucker.exe Count input.txt"
        })]
    public void Count(
        [Operand(Description = "path to source file")]string path)
    {
        string input = Files.ImportInput(path);

        if (!File.Exists(path))
        {
            Console.WriteLine("Error: File not found. Check path, maybe?");
        }
        else
        {
            Dictionary<char, int> pairs = new Dictionary<char, int>();
        
            foreach (var letter in input.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    Counter.UpdateDict(pairs, letter);
                    Counter.letterCounter++;
                }
            }
            Console.WriteLine($"Letters total: {Counter.LetterCount(input)}");
            Counter.PrintSet(Counter.OrderByValue(pairs));
            Console.WriteLine("--------------");
            Counter.PrintSortedSet(Counter.GetSortedByKey(pairs));
        }
    }
}