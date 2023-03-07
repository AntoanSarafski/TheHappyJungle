using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Foods;

namespace TheHappyJungle.Models.Animals
{
    public class Cat : Feline
    {

        private const double CatWeightMultiplier = 0.3;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => CatWeightMultiplier;

        public override IReadOnlyCollection<Type> PreferredFoods
             => new HashSet<Type> {
                typeof(Vegetable),
                typeof(Meat) };

        public override string ProduceSound()
            => $"Meow";
    }
}
