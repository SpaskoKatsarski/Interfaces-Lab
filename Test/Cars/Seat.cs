using System;
using System.Collections.Generic;
using System.Text;
using Test.Cars.Interfaces;

namespace Test.Cars
{
    public class Seat : Car, ICar
    {
        private int fuel;

        public Seat(string model, int fuel)
            : base(model, 250)
        {
            this.Fuel = fuel;
        }

        public int Fuel
        {
            get
            {
                return this.fuel;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid fuel.");
                }

                this.fuel = value;
            }
        }

        public new void Beep()
        {
            Console.WriteLine("BEEEP!");
        }

        public new void Drive()
        {
            Console.WriteLine("OK IM DRIVING!!");
            this.Fuel--;
        }
    }
}
