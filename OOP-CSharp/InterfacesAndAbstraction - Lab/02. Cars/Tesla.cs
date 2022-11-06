using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : IElectricCar
    {
        public int Battery { get; private set; }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public Tesla(string model,string color,int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public string Start()
        {
            return "Start Engine";
        }

        public string Stop()
        {
            return "Stop Engine";
        }
        public override string ToString()
        {
            return $"{Color} {nameof(Tesla)} {Model} with {Battery}";
        }
    }
}
