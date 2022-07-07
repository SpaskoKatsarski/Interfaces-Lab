using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Cars
{
    public abstract class Car
    {
        private string model;
        private int hp;

        public Car(string mdoel, int hp)
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

    }
}
