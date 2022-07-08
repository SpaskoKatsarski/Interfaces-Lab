using System;
using System.Collections.Generic;
using System.Text;
using Test.Cars.Interfaces;

namespace Test.Cars
{
    public abstract class Car : ICar
    {
        private string model;
        private int hp;

        public Car(string model, int hp)
        {
            this.Model = model;
            this.HP = hp;
        }

        public string Model
        {
            get 
            { 
                return this.model; 
            }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.model = value; 
            }
        }

        public int HP
        {
            get
            {
                return this.hp;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Horse powers cannot be negative.");
                }

                this.hp = value;
            }
        }

        public virtual void Drive()
        {
            Console.WriteLine("Im Driviiing!!!");
        }

        public virtual void Beep()
        {
            Console.WriteLine("Beep beep beep beep");
        }
    }
}
