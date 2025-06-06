using System;
using System.IO;

namespace CrossCutting.Log
{
    public class Log
    {
        private DateTime _timeNow = DateTime.Now;
        private List<string> messages = new List<string>();
        public void InsertAndPush(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" -> [{_timeNow}] : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" {message}");
            Console.WriteLine("<==============================================>");
        }

        public Log Insert(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            messages.Add(message);
            return this;
        }
        public void Push()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" -> [{_timeNow}]");
            Console.ForegroundColor = ConsoleColor.White;
            if (messages.Count < 0) return;
            foreach (string message in messages)
            {
                Console.WriteLine($"{message}");
            }
            Console.WriteLine("<==============================================>");
        }
    }

}