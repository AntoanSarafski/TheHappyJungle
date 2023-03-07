using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Foods;

namespace TheHappyJungle.Models.Animals
{
    public class Tiger : Feline
    {

        private const double TigerWeightMultiplier = 1.0;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => TigerWeightMultiplier;

        public override IReadOnlyCollection<Type> PreferredFoods
             => new HashSet<Type> { typeof(Meat) };

        public override string ProduceSound()
            => $"ROAR!!!!";
    }
}
