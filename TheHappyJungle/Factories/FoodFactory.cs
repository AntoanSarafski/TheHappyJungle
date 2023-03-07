using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Factories.Interfaces;
using TheHappyJungle.Models.Foods;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Factories
{
    public class FoodFactory : IFoodFactory
    {
        public IFood CreateFood(string type, int quantity)
        {
            switch (type)
            {
                case "Vegetable":
                    return new Vegetable(quantity);

                case "Fruit":
                    return new Fruit(quantity);

                case "Meat":
                    return new Meat(quantity);
                     
                case "Seeds":
                    return new Seeds(quantity);

                default:
                    throw new ArgumentException("Invalid type of food");
            }
        }
    }
}
