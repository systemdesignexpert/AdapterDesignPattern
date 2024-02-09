// SerilogLogger.cs
using System;

public class SerilogLogger
{
    public void Information(string message)
    {
        // Simulate Serilog logging
        Console.WriteLine($"Serilog Information: {message}");
    }

    public void Error(string message)
    {
        // Simulate Serilog logging
        Console.WriteLine($"Serilog Error: {message}");
    }
}
