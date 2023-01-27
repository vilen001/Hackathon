namespace FieryRestaurent.LoggingService
{
    public interface ILoggerManager
    {
        public void LogCritical(string message);
        public void LogWarning(string message);
        public void LogDebug(string message);
        public void LogError(string message);
        public void LogInfo(string message);   
        public void LogTrace(string message);
    }
}