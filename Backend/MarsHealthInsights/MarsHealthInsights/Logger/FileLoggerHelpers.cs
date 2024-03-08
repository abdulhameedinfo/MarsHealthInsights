using MarsHealthInsights.Logger;

internal static class FileLoggerHelpers
{
    public static void Write(string path, string message, string messageType)
    {
        using (var steamWrite = new StreamWriter(path, true))
        {
            steamWrite.WriteLine(messageType + ": " + message);
        }
    }
}