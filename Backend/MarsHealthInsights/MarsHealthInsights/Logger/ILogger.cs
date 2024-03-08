namespace MarsHealthInsights.Logger
{
    public interface ICustomLogger
    {
        public void Info(string message);
        public void Warn(string message);
        public void Error(string message);
        public void Fatal(string message);
        public void Fatal(string message, Exception exception);
    }
}
