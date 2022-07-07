using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Cars.Interfaces
{
    public interface IElectricCar : ICar
    {
        public int BatteryValue { get; set; }

        public void ChargeBattery();

        public void CustomizeHornSound();
    }
}
