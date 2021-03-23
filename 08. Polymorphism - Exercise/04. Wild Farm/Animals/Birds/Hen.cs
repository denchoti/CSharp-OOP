﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm2.Foods;

namespace WildFarm2.Animals.Birds
{
    public class Hen : Bird
    {
        private const double weightModifier = 0.35;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable),
            nameof(Seeds),
            nameof(Fruit),
        };

        public Hen(string name, double weight, double wingSize) : base(name, weight, allowedFoods, weightModifier, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}