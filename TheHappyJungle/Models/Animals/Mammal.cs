using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Models.Animals
{
    public abstract class Mammal : Animal, IMammal
    {
        protected Mammal(string name, double weight, string livingRegion) 
            : base(name, weight)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }
    }
}
