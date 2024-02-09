using System;

	public class FileLoggerAdapter: ILogger
	{
		FileLogger fileLogger;
		public FileLoggerAdapter(FileLogger _fileLogger)
		{
			this.fileLogger = _fileLogger;
		}

        public void LogError(string message)
        {
            this.fileLogger.writeError(message);
        }

        public void LogInfo(string message)
        {
            this.fileLogger.writeInfo(message);
        }
    }


