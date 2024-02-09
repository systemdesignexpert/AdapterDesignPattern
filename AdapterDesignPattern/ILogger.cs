// ILogger.cs
using System;

public interface ILogger
{
    void LogInfo(string message);
    void LogError(string message);
}
