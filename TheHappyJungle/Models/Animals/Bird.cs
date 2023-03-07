using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Models.Animals
{
    public abstract class Bird : Animal, IBird
    {
        protected Bird(string name, double weight, double wingSize)
            :base(name, weight)
        {
            WingSize = wingSize;
        }
        public double WingSize { get; private set; }

        public override string ToString()
                => $"{base.ToString()}{WingSize}, {Weight}, {FoodEaten}]";
        
    }
}
