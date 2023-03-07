using System;
using TheHappyJungle.IO.Interfaces;

namespace TheHappyJungle.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string str)
            => Console.WriteLine(str);
    }
}
