using System;
using System.Linq;

namespace BuilderPattern
{
    public class Bus : Vehicle
    {
        public override void Embus(Passenger passenger)
        {
            if (Passengers.Count == Capacity)
            {
                Console.WriteLine($"{GetType().Name} maximum capacity reached. Consider start now.");
                return;
            }
            
            switch (passenger.GetType().Name)
            {
                case "AdultPassenger":
                    if (passenger.Pay(Price) > 0)
                    {
                        Passengers.Add(passenger);
                    }

                    break;
                case "ChildPassenger":
                    if (passenger.Pay(Price * 0.5f) > 0)
                    {
                        Passengers.Add(passenger);
                    }

                    break;
                case "PrivilegedPassenger":
                    Passengers.Add(passenger);
                    break;
            }
        }

        public override void Embus(Driver driver)
        {
            Driver = driver;
        }

        protected override bool IsAbleToStart()
        {
            return Passengers.Any() && Driver != null;
        }
    }
}