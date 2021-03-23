using System;
using System.Collections.Generic;
using System.Text;
using WildFarm2.Foods;

namespace WildFarm2.Animals.Feline
{
    public class Tiger : Feline
    {
        private const double weightModifier = 1;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat),

        };

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, allowedFoods, weightModifier, livingRegion, breed)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}