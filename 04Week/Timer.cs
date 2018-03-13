using System;
using System.Diagnostics;
using System.Threading;

class Timer
{
    static void Main()
    {
        // Create new stopwatch.
        Stopwatch stopwatch = new Stopwatch();

        // Begin timing.
        stopwatch.Start();
        Stopwatch.Elapsed


        // Stop timing.
        stopwatch.Stop();

        TimeSpan duration = new TimeSpan;

        // Write result.
        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        Console.ReadLine();
    }
}
