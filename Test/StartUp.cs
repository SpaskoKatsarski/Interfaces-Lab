using System;
using Test.Cars;

namespace Test
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Tesla tesla = new Tesla(50, "Model X");
            Console.WriteLine(tesla.BatteryValue);

            for (int i = 0; i < 50; i++)
            {
                tesla.ChargeBattery();
            }

            tesla.Drive();
            Console.WriteLine(tesla.BatteryValue);
            tesla.Beep();
            tesla.CustomizeHornSound();
        }
    }
}
