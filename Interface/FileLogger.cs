using System;

namespace Interface
{
    public class FileLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Dosyaya log yazarım.");
        }
    }
}