namespace letter_fucker;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let the letter-fucking begin! :D");

        string testData = "AAAAaaaaBBBbbbQQ";

        Dictionary<char, int> pairs = new Dictionary<char, int>();
        
        foreach (var letter in testData.ToLower())
        {
            if (Char.IsLetter(letter))
            {
                UpdateDict(pairs, letter);
            }
        }
        PrintSet(pairs);
        
    }

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
}


