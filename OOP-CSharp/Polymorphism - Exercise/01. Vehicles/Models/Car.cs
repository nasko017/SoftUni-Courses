
namespace Vehicles.Models
{
    using Contracts;
    public class Car : Vehicle
    {
        private const double FUEL_INCREMENT = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption, FUEL_INCREMENT)
        {
        }
    }
}
