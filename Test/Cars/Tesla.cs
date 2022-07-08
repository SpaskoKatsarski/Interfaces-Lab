using System;
using System.Collections.Generic;
using System.Text;
using Test.Cars.Interfaces;

namespace Test.Cars
{
    public class Tesla : Car, IElectricCar
    {
        private int bv;

        public Tesla(int batteryValue, string model)
            : base(model, 500)
        {
            this.BatteryValue = batteryValue;
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

        public void ChargeBattery()
        {
            this.BatteryValue++;
        }

        public void CustomizeHornSound()
        {
            Console.WriteLine("Customized!");
        }

        public override void Drive()
        {
            Console.WriteLine("Vroom Vroom!");
            this.BatteryValue--;
        }

        public override void Beep()
        {
            Console.WriteLine("Tururur");
        }
    }
}
