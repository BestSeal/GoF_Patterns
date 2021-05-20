using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactoryAndSingleton
{
    public abstract class Vehicle
    {
        public Vehicle(int capacity, float price, Type driverType)
        {
            
            Capacity = capacity;
            Price = price;
            this.DriverType = driverType;
            Passengers = new List<Passenger>();
        }

        public readonly Type DriverType;
        public int Capacity { get; protected set; }
        public float Price { get; protected set; }

        public ICollection<Passenger> Passengers { get; protected set; }

        public Driver Driver { get; protected set; }

        public abstract void Embus(Driver driver);

        public virtual void Embus(Passenger passenger)
        {
            if (Passengers.Count < Capacity)
            {
                if (passenger.Pay(Price) > 0)
                {
                    Passengers.Add(passenger); 
                }
                else
                {
                    throw new Exception("Passenger don't have enough money.");
                }
            }
            else
            {
                throw new Exception("Capacity limit exceed, no more passengers can embus.");
            }
        }

        public virtual bool Launch()
        {
            if (Driver == null || !Passengers.Any()) return false;
            
            Console.WriteLine($"The {GetType().FullName?.Split('.').Last() ?? "vehicle"} leaves station with {Passengers.Count} passenger(s)");
            return true;

        }
    }
}