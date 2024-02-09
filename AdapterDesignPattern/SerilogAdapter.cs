// SerilogAdapter.cs
public class SerilogAdapter : ILogger
{
    private SerilogLogger _serilogLogger;

    public SerilogAdapter(SerilogLogger serilogLogger)
    {
        _serilogLogger = serilogLogger;
    }

    public void LogInfo(string message)
    {
        _serilogLogger.Information(message);
    }

    public void LogError(string message)
    {
        _serilogLogger.Error(message);
    }
}
