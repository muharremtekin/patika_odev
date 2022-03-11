using System;

namespace Interface
{
    public class SmsLogger:ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Sms olarak log yazarım.");
        }
    }
}