using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Models
{
    abstract class Feline : IFeline
    {
        public string Breed => throw new NotImplementedException();
    }
}
