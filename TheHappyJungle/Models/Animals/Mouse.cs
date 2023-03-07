using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Foods;

namespace TheHappyJungle.Models.Animals
{
    public class Mouse : Mammal
    {
        protected const double MouseWeightMultiplier = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => MouseWeightMultiplier;

        public override IReadOnlyCollection<Type> PreferredFoods
             => new HashSet<Type> {
                typeof(Vegetable),
                typeof(Fruit) };


        public override string ProduceSound()
            => $"Squeak";

        public override string ToString()
                => $"{base.ToString()}{Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
