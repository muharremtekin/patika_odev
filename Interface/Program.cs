using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.writeLog();
            
            DatabaseLogger dblogger = new DatabaseLogger();
            dblogger.writeLog();

            SmsLogger smsLog = new();
            smsLog.writeLog();

            LogManager logManager = new(new FileLogger());
            logManager.writeLog();
        }
    }
}
