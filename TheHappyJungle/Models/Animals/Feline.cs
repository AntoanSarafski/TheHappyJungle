using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Animals;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Models
{
    public abstract class Feline : Mammal, IFeline
    {
        protected Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get; private set; }
    }
}
