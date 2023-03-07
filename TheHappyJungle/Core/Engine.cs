using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Core.Interfaces;
using TheHappyJungle.IO.Interfaces;

namespace TheHappyJungle.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
