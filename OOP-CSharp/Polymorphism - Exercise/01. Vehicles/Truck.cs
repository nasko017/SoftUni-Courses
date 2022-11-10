using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FUEL_INCREMENT = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption, FUEL_INCREMENT)
        {
        }
        public override void Refuel(double litters)
        {
            base.Refuel(litters*0.95);
        }
        
    }
}
