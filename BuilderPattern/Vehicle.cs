using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public abstract class Vehicle
    {
        protected Vehicle()
        {
            Passengers = new List<Passenger>();
        }
        public int Capacity { get; set; }

        public float Price { get; set; }
        
        protected List<Passenger> Passengers { get; }
        
        protected Driver Driver { get; set; }

        public abstract void Embus(Passenger passenger);

        public abstract void Embus(Driver driver);
        protected abstract bool IsAbleToStart();

        public void Start()
        {
            Console.WriteLine(IsAbleToStart() ? $"{GetType().Name} starts with {Passengers.Count} on board." : $"{GetType()} can't start right now.");
        }
    }
}