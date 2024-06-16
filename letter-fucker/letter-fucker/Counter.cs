namespace letter_fucker;

public static class Counter
{
    public static void DoTheThing(string input)
    {
        Dictionary<char, int> pairs = new Dictionary<char, int>();
        
        foreach (var letter in input.ToLower())
        {
            if (Char.IsLetter(letter))
            {
                UpdateDict(pairs, letter);
            }
        }
        Console.WriteLine($"Letters total: {LetterCount(input)}");
        PrintSet(OrderByValue(pairs));
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
    
    public static void CreateNewOrUpdateExisting<TKey, TValue>(IDictionary<TKey, TValue> map, TKey key, TValue value)
    {
        map[key] = value;
    }

    public static void PrintSet(Dictionary<char, int> input)
    {
        foreach (KeyValuePair<char, int> item in input)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        Console.WriteLine("---");
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
}