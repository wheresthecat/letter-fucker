namespace letter_fucker;

public class Experiments
{
    // Garbage code, code for testing and other stuff
    public static void BasicExperiment()
    {
        Console.WriteLine("Let the letter-fucking begin! :D");

        string dir = Environment.GetFolderPath((Environment.SpecialFolder.MyDocuments));
        string fileName = "input.txt";
        string path = Path.Combine(dir, fileName);

        string inputData = Files.ImportInput(path);

        //Counter.Count(inputData);
    }
}