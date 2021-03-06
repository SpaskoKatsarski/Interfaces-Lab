using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color , int batteris)
        {
            this.Model = model;
            this.Color = color;
            this.Batteris = batteris;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public int Batteris { get; private set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Color} Tesla {this.Model} with {this.Batteris} Batteries");
            result.AppendLine(this.Start());
            result.AppendLine(this.Stop());

            return result.ToString().TrimEnd();
        }
    }
}
