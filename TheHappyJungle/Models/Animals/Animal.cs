using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Models
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract double WeightMultiplier { get; }

        public abstract IReadOnlyCollection<Type> PreferredFoods { get; }


        public abstract string ProduceSound();

        public void Eat(IFood food)
        {
            if (!PreferredFoods.Any(pf => pf.Name == food.GetType().Name))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            FoodEaten += food.Quantity;
            Weight += food.Quantity * WeightMultiplier;
        }

        public override string ToString()
            => $"{GetType().Name} [{Name}, ";

    }
}
