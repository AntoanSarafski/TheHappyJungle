using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Foods;

namespace TheHappyJungle.Models.Animals
{
    public class Dog : Mammal
    {
        protected const double DogWeightMultiplier = 0.40;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => DogWeightMultiplier;

        public override IReadOnlyCollection<Type> PreferredFoods
             => new HashSet<Type> { typeof(Meat) };

        public override string ProduceSound()
            => $"Woof!";

        public override string ToString()
                => $"{base.ToString()}{Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
