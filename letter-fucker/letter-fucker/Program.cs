namespace letter_fucker;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let the letter-fucking begin! :D");

        string testData = "I worked at a walmart as a cashier while in college for about 3 months just to get some cash for books. I never had to do anything really demeaning, I'm pretty sure the managers bullshitted a lot of things, but I do have a funny story. While working there one of the managers got fired, and his replacement learned I was a chemical engineering student. So he pulled me into his office and genuinely asked me how they make water. I thought he was joking but once I figured out he was being serious I tried to get him to elaborate to which he explained that he thought tap water came from the water factory. I kinda explained that water wasn't really made and it was filtered from a sewage treatment plant and he got pretty concerned. He asked if bottled water was safe and I just said sure to quell his worries and from that day on he was never seen drinking out of anything but bottled water. The day I quit he shook my hand and said thank you for explaining it to him. For all I know he's still out there sippin' a bottled water.";

        Dictionary<char, int> pairs = new Dictionary<char, int>();
        
        foreach (var letter in testData.ToLower())
        {
            if (Char.IsLetter(letter))
            {
                UpdateDict(pairs, letter);
            }
        }
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
}


