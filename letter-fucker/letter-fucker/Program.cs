namespace letter_fucker;
using System;
using CommandDotNet;

class Program
{
    static void Main(string[] args)
    {

    }

    public static void PrimaryRun()
    {
        Console.WriteLine("Let the letter-fucking begin! :D");

        string dir = Environment.GetFolderPath((Environment.SpecialFolder.MyDocuments));
        string fileName = "input.txt";
        string path = Path.Combine(dir, fileName);

        string inputData = Files.ImportInput(path);

        Counter.DoTheThing(inputData);
        
        //TODO: Add percentual frequency of letters.
        //TODO: Add options of output
        //TODO: Refactor file reading (exceptions, more robustness)
        //TODO: Sorted Dictinary instead of diy sorting
        //TODO: COMMAND LINE ARGUMENTS! COMMANDDOTNET
    }
}


