// Application.cs
class Application
{
    static void Main(string[] args)
    {

        // Using Serilog
        SerilogLogger serilogLogger = new SerilogLogger();
        Log4NetLogger log4NetLogger = new Log4NetLogger();
        FileLogger fileLogger = new FileLogger();

        // Logging messages
        //serilogLogger.Information("This is an informational message.");
        //log4NetLogger.LogInfo("This is an informational message.");


        ILogger logger1 = new SerilogAdapter(serilogLogger);
        ILogger logger2 = new Log4NetAdapter(log4NetLogger);
        ILogger logger3 = new FileLoggerAdapter(fileLogger);


        // dev/user of the codebase
        logger1.LogInfo("This is an informational message.");
        logger2.LogInfo("This is an informational message.");
        logger2.LogError("error is logged");
        logger3.LogError("error is logged again");



    }
}
