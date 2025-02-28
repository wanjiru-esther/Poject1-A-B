using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Producer runs the `ls` command and sends the output to the Consumer
        ProcessStartInfo lsInfo = new ProcessStartInfo()
        {
            FileName = "ls",  // This runs the `ls` command to list files
            RedirectStandardOutput = true, // Captures the output
            UseShellExecute = false // There is no use to open a shell
        };

        Process? lsProcess = Process.Start(lsInfo);

        if (lsProcess == null)
        {
            Console.WriteLine("Error: Program Failed to start  the `ls` process. Please try again!");
            return;
        }

        // Consumer reads the output from `ls` and processes it
        Console.WriteLine("Consumer: Receiving the `ls` output and processing it...\n");

        using (StreamReader reader = lsProcess.StandardOutput) // This reads the output of the `ls`
        {
            string? line;  // Allow line to be nullable to handle the `null` return from ReadLine()
            while ((line = reader.ReadLine()) != null) // Reads each line
            {
                // Here, we simply print each line to the console (processing the file names)
                Console.WriteLine($"Consumer: Processing file ===> {line.ToUpper()}"); // Convert the file name to uppercase
            }
        }

        lsProcess.WaitForExit(); // Waiting for the `ls` process to finish
        Console.WriteLine("\nProducer and Consumer have finished.");
    }
}

/****ProjectB: Output
*Consumer: Receiving the `ls` output and processing it...

*Consumer: Processing file ===> BIN
*Consumer: Processing file ===> CONSOLEAPP1.CSPROJ
*Consumer: Processing file ===> OBJ
*Consumer: Processing file ===> PROGRAM.CS

Producer and Consumer have finished.
**/