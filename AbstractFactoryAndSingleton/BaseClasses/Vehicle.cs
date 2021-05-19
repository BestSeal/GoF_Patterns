using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactoryAndSingleton.BaseClasses
{
    public abstract class Vehicle
    {
        public int Capacity { get; protected set; }
        public int Price { get; protected set; }

        public ICollection<Passenger> Passengers { get; protected set; }

        public Driver Driver { get; protected set; }

        public abstract void Embus(Driver driver);

        public abstract void Embus(Passenger passenger);

        public virtual void Launch()
        {
            Console.WriteLine(Driver is not null && Passengers.Any() ? "Поехали!" : "Может потом?");
        }
        
        public Vehicle(int capacity, int price)
        {
            Capacity = capacity;
            Price = price;
        }
    }
}