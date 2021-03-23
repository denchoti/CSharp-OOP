﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm2.Foods;

namespace WildFarm2.Animals.Birds
{
    public class Owl : Bird
    {
        private const double weightModifier = 0.25;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat),

        };

        public Owl(string name, double weight, double wingSize) : base(name, weight, allowedFoods, weightModifier, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}

