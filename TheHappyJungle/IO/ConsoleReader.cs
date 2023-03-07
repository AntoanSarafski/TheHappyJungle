using System;
using TheHappyJungle.IO.Interfaces;

namespace TheHappyJungle.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
            => Console.ReadLine();
    }
}
