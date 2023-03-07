using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Foods;

namespace TheHappyJungle.Models.Animals
{
    public class Owl : Bird
    {
        private const double OwlWeightMultiplier = 0.25;


        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => OwlWeightMultiplier;

        public override IReadOnlyCollection<Type> PreferredFoods
            => new HashSet<Type> { typeof(Meat) }; // It can be const like OwlWeightMultiplier. This is just different way.


        public override string ProduceSound()
            => $"Hoot Hoot";
    }
}
