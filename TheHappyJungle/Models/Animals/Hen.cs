using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Foods;

namespace TheHappyJungle.Models.Animals
{
    public class Hen : Bird
    {
        private const double HenWeightMultiplier = 0.35;


        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => HenWeightMultiplier;

        public override IReadOnlyCollection<Type> PreferredFoods
            => new HashSet<Type> { 
                typeof(Meat),
                typeof(Vegetable),     // It can be const like OwlWeightMultiplier. This is just different way.
                typeof(Fruit), 
                typeof(Seeds) }; 
        


        public override string ProduceSound()
            => $"Cluck";
    }
}
