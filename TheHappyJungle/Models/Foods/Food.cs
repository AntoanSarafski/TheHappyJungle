using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Models.Foods
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; private set; }
    }
}
