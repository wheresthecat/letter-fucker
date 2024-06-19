using CommandDotNet;
using CommandDotNet.Rendering;

namespace letter_fucker;

public class Counter
{
    private static int letterCounter;
    // Defaul and main function. It all gets worked there.
    [Command(Description = "Counts the frequency of letters in a text.",
        UsageLines = new[]
        {
            "Count [source file path] (txt)",
            "%AppName% %CmdPath% file.txt"
        },
        ExtendedHelpTextLines = new[]
        {
            "Count [source file path] (txt)",
            "%AppName% %CmdPath% file.txt"
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
                    UpdateDict(pairs, letter);
                    letterCounter++;
                }
            }
            Console.WriteLine($"Letters total: {LetterCount(input)}");
            PrintSet(OrderByValue(pairs));
            Console.WriteLine("--------------");
            PrintSortedSet(GetSortedByKey(pairs));
        }
    }
    
    // Update or add new. If key is already existed it just increment the value by one. If not, adds a new key/value part.

    public static void UpdateDict(Dictionary<char, int> inputDict, char inputKey)
    {
        int newValue = 0;
        if (inputDict.TryGetValue(inputKey, out newValue))
        {
            newValue += 1;
            CreateNewOrUpdateExisting(inputDict, inputKey, newValue);
        }
        else
        {
            inputDict.Add(inputKey, 1);
        }
    }
    
    private static void CreateNewOrUpdateExisting<TKey, TValue>(IDictionary<TKey, TValue> map, TKey key, TValue value)
    {
        map[key] = value;
    }

    public static Dictionary<char, int> OrderByValue(Dictionary<char, int> input)
    {
        Dictionary<char, int> orderedDict = new Dictionary<char, int>();

        foreach (KeyValuePair<char, int> item in input.OrderByDescending(key => key.Value))
        {
            orderedDict.Add(item.Key, item.Value);
        }

        return orderedDict;
    }

    public static SortedDictionary<char, int> GetSortedByKey(Dictionary<char, int> input)
    {
        SortedDictionary<char, int> sortedOutput = new SortedDictionary<char, int>();
        foreach (KeyValuePair<char, int> item in input)
        {
            sortedOutput.Add(item.Key, item.Value);
        }
        
        return sortedOutput;
    }

    public static int LetterCount(string input)
    {
        int letterCounter = 0;
        foreach (var letter in input)
        {
            if (Char.IsLetter(letter))
            {
                letterCounter++;
            }
        }
        return letterCounter;
    }
    
    // Printing stuff
    public static void PrintSet(Dictionary<char, int> input)
    {
        foreach (KeyValuePair<char, int> item in input)
        {
            Console.WriteLine($"{item.Key} - {item.Value} ({Common.GetPercents(item.Value, letterCounter)}%)");
        }
        Console.WriteLine("---");
    }

    public static void PrintSortedSet(SortedDictionary<char, int> input)
    {
        foreach (KeyValuePair<char, int> item in input)
        {
            Console.WriteLine($"{item.Key} - {item.Value} ({Common.GetPercents(item.Value, letterCounter)}%)");
        }
    }
}