namespace MarsHealthInsights.Logger
{
    public class ConsoleLogger : ICustomLogger
    {
        public void Error(string message)
        {
            Console.WriteLine("Error", message);
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
            Console.WriteLine("Info", message);
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }
    }
}
