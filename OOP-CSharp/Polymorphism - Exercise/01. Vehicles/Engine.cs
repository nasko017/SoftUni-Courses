
namespace Vehicles.Core
{
    using System;
    using Contracts;
    using Vehicles.IO.Contracts;
    using Vehicles.Models;
    using Vehicles.Models.Contracts;

    public class Engine : IEngine
    {
        private readonly IWriter writer;
        private readonly IReader reader;

        private  IVehicle car;
        private  IVehicle truck;

        
        public Engine(IWriter writer, IReader reader)
        {
            this.writer = writer;
            this.reader = reader;
        }
        
        public void Run()
        {
            string[] carArg = reader.ReadLine().Split(' ');
            double carFuelQnty = double.Parse(carArg[1]);
            double carFuelConsumption = double.Parse(carArg[2]);

            string[] truckArg = reader.ReadLine().Split(' ');
            double truckFuelQnty = double.Parse(truckArg[1]);
            double truckFuelConsuption = double.Parse(truckArg[2]);

            car = new Car(carFuelQnty, carFuelConsumption);

            truck = new Truck(truckFuelQnty, truckFuelConsuption);

            int n = int.Parse(reader.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArg = reader.ReadLine().Split(' ');
                string commandType = commandArg[0];
                string vehicleType = commandArg[1];
                double thirdArg = double.Parse(commandArg[2]);

                try
                {
                    if (vehicleType == "Car")
                    {
                        if (commandType == "Drive")
                        {
                            writer.WriteLine(car.Drive(thirdArg));
                        }
                        else
                        {
                            car.Refuel(thirdArg);
                        }
                    }
                    else if (vehicleType == "Truck")
                    {
                        if (commandType == "Drive")
                        {
                            writer.WriteLine(truck.Drive(thirdArg));
                        }
                        else
                        {
                            truck.Refuel(thirdArg);
                        }
                    }
                }
                catch (ArgumentException ae)
                {
                    writer.WriteLine(ae.Message);
                   
                }
            }
            writer.WriteLine(car.ToString());
            writer.WriteLine(truck.ToString());
        }


    }
}
