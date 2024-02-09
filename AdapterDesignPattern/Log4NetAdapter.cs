// Log4NetAdapter.cs
public class Log4NetAdapter : ILogger
{
    private Log4NetLogger _log4NetLogger;

    public Log4NetAdapter(Log4NetLogger log4NetLogger)
    {
        _log4NetLogger = log4NetLogger;
    }

    public void LogInfo(string message)
    {
        _log4NetLogger.LogInfo(message);
    }

    public void LogError(string message)
    {
        _log4NetLogger.LogError(message);
    }
}
