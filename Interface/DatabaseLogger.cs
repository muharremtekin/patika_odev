using System;

namespace Interface
{
    public class DatabaseLogger:ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Veritabanına log yazarım.");
        }
    }
}