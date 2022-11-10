using System;
using Vehicles.Core;
using Vehicles.Core.Contracts;
using Vehicles.IO;
using Vehicles.IO.Contracts;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(writer, reader);
            engine.Run();
        }
    }
}
