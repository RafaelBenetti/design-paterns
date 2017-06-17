using System.Text;

namespace DesignPatterns.CreationalPatterns.Singleton.Report
{
    public static class ProcessReport
    {
        private static object _objectToControlLock = new object();
        private static StringBuilder _messages = new StringBuilder();

        public static void Add(string message)
        {
            // It only make sense because the order of messages matter.
            lock (_objectToControlLock)
                _messages.Append(message);
        }

        public static string GetCompleteReport()
        {
            lock (_objectToControlLock)
                return _messages.ToString();
        }

        public static void Clear()
        {
            lock (_objectToControlLock)
                _messages.Clear();
        }
    }
}
