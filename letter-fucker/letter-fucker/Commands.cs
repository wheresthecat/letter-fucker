namespace letter_fucker;
using CommandDotNet;

public class Commands
{
    [DefaultCommand]
    public void Execute()
    {
        Console.WriteLine("Hello there. Default Command.");
    }
}