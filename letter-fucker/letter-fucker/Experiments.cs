namespace letter_fucker;

public class Experiments
{
    public static void BasicExperiment()
    {
        Console.WriteLine("Let the letter-fucking begin! :D");

        string dir = Environment.GetFolderPath((Environment.SpecialFolder.MyDocuments));
        string fileName = "input.txt";
        string path = Path.Combine(dir, fileName);

        string inputData = Files.ImportInput(path);

        //Counter.Count(inputData);
        
        //TODO: Add percentual frequency of letters.
        //TODO: Add options of output
        //TODO: Refactor file reading (exceptions, more robustness)
        //TODO: Sorted Dictinary instead of diy sorting
        //TODO: COMMAND LINE ARGUMENTS! COMMANDDOTNET
    }
}