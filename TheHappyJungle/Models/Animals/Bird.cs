using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Models.Animals
{
    abstract class Bird : IBird
    {
        public double WingSize { get; private set; }
    }
}
