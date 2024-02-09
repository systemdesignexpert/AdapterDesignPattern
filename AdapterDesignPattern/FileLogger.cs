using System;

	public class FileLogger
	{
		public FileLogger()
		{
		}

		public void writeInfo(string message)
		{
			// logic to write in a file
			Console.WriteLine("File Logger Info:" + message);
		}

        public void writeError(string message)
        {
            // logic to write in a file
            Console.WriteLine("File Logger Error:" + message);
        }

    }


