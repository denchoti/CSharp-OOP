﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm2.Foods;

namespace WildFarm2.Animals.Feline
{
    public class Cat : Feline
    {
        private const double weightModifier = 0.30;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable),

        };

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, allowedFoods, weightModifier, livingRegion, breed)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}