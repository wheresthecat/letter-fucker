namespace letter_fucker;
using System;
using CommandDotNet;

class Program
{
    static int Main(string[] args) => AppRunner.Run(args);

    public static AppRunner AppRunner => new AppRunner<Counter>();
}


// Process:
// Count all letter for later % counting.


//TODO: Add frequency of letters in percents.
//TODO: Add options of output
//TODO: Sorted Dictionary instead of diy sorting
//TODO: COMMAND LINE ARGUMENTS! -- I sort of started this, but it's really crude, fucked up and barely working piece of shit.

//(Done, sort of): Refactor file reading (exceptions, more robustness)
