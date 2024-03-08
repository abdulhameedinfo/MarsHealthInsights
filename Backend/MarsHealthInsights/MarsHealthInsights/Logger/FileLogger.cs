namespace MarsHealthInsights.Logger
{
    public class FileLogger : ICustomLogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }
        public void Error(string message)
        {
            FileLoggerHelpers.Write(path, message, "Error");
        }

        public void Fatal(string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            FileLoggerHelpers.Write(path, message, "Info");
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }
    }
}
