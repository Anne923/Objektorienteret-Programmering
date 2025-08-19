using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_Dependency
{
    public class FileLogger : ILogger
    {
        private readonly string filePath = "log.txt";
        public void Log(string message)
        {
            File.AppendAllText(filePath, $"[File] {message}{Environment.NewLine}");
            Console.WriteLine($"[File] {message}"); // Optional: also log to console for visibility
        }
    }
}
