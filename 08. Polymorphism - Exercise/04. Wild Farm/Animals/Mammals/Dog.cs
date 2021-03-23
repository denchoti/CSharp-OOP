using System;
using System.Collections.Generic;
using System.Text;
using WildFarm2.Foods;

namespace WildFarm2.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double weightModifier = 0.40;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat),

        };

        public Dog(string name, double weight, string livingRegion) : base(name, weight, allowedFoods, weightModifier, livingRegion)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
