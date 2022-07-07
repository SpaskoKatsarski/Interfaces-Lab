using System;
using System.Collections.Generic;
using System.Text;
using Test.Cars.Interfaces;

namespace Test.Cars
{
    public class Tesla : IElectricCar
    {
        private int bv;
        private string model;

        public Tesla(int batteryValue, string model)
        {
            this.BatteryValue = batteryValue;
            this.Model = model;
        }

        public int BatteryValue
        {
            get
            {
                return this.bv;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery charge.");
                }

                this.bv = value;

                if (value > 100)
                {
                    throw new ArgumentException($"You overcharged and broke the battery of the car.");
                }
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"Model cannot be empty name.");
                }

                this.model = value;
            }
        }

        public void Beep()
        {
            Console.WriteLine("Tururur");
        }

        public void ChargeBattery()
        {
            this.BatteryValue++;
        }

        public void CustomizeHornSound()
        {
            Console.WriteLine("Customized!");
        }

        public void Drive()
        {
            Console.WriteLine("Vroom Vroom!");
            this.BatteryValue--;
        }
    }
}
