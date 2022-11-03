using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SportCar supra = new SportCar(200, 20);
            supra.Drive(10);
        }
    }
}
