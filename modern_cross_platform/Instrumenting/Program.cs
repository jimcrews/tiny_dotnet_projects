using System.IO;
using System.Diagnostics;

namespace Instrumenting
{
    /// <summary>
    /// When running with the Debug configuration, both Debug and Trace are active and will show their output in DEBUG CONSOLE. 
    /// When running with the Release configuration, only the Trace output is shown. 
    /// You can therefore use 'Debug.WriteLine' calls liberally throughout your code, knowing they will be stripped out automatically 
    /// when you build the release version of your application.
    /// 
    /// dotnet run --configuration Release
    /// dotnet run --configuration Debug
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            // write to a text file in the project folder
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            // text writer is buffered, so this option calls
            // Flush() on all listeners after writing
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");
        }
    }
}
