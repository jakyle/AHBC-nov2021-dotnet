using System;
using System.Collections.Generic;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loggerr = new Logger();
            var emailLogger = new EmailLogger();
            var textLogger = new TextMessageLogger();

            var loggers = new List<Logger>();
            loggers.Add(emailLogger);
            loggers.Add(loggerr);
            loggers.Add(textLogger);

            foreach (var logger in loggers)
            {
                logger.Log("hello world!");
            }
        }
    }
}
