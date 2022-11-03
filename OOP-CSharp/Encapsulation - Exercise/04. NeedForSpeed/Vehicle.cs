using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public double DefaultFuelConsumption { get; set; } = 1.25;
        public virtual double FuelConsumption { get; set; }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public Vehicle(int horsepower, double fuel)
        {
            this.HorsePower = horsepower;
            this.Fuel = fuel;
        }
        public virtual void Drive(double kilometes)
        {
            Fuel -= (kilometes * DefaultFuelConsumption);
        }
    }
}
