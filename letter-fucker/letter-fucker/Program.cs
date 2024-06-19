namespace letter_fucker;
using System;
using CommandDotNet;

class Program
{
    static int Main(string[] args) => AppRunner.Run(args);

    public static AppRunner AppRunner => new AppRunner<Commands>();
}


