using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Models.Animals
{
    abstract class Mammal : IMammal
    {
        public string LivingRegion { get; private set; }

    }
}
