using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
   public class Truck : Vehicle
    {
        private const double TruckAirConditionerModifer = 1.6;

        public Truck(double fuel, double fuelConsumption) : base(fuel, fuelConsumption, TruckAirConditionerModifer)
        {
        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount * 0.95);
        }
    }
}
