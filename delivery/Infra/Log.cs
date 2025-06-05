using System.IO;
using System.Runtime.CompilerServices;

namespace Delivery.Web.Pdv.Infra
{
    public class Log
    {
        /* Singleton!! */
        private static readonly Log _log = new Log();
        private static TextWriter _w;
        StreamWriter file = File.AppendText("logsystem.LOG");
        private Log() { } 
        public static Log Instance => _log;
        public static void RawWriteAndConsole(string logMsg)
        {
            Console.WriteLine($"In: {DateTime.Now.ToLongDateString()}");
            Console.Write($"{logMsg}");
            _w.Write($"{logMsg}");
        }
    }
}
