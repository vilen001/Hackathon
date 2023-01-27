
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.LoggingService
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public void LogCritical(string message)
        {
            logger.Fatal(message);
        }
        public void LogWarning(string message)
        {
            logger.Warn(message);
        }

        public void LogDebug(string message)
        {
            logger.Debug(message);
        }
        public void LogError(string message)
        {
            logger.Error(message);
        }
        public void LogInfo(string message)
        {
            logger.Info(message);
        }
        public void LogTrace(string message)
        {
            logger.Trace(message);
        }
    }
}
