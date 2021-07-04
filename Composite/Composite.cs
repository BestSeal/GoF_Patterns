using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Composite : IComponent
    {
        protected readonly ICollection<IComponent> Components;
        private float _baggageWeight;

        public float BaggageWeight
        {
            get => Components.Sum(c => c.BaggageWeight);
            set => _baggageWeight = value;
        }

        public float BaggageWeightLimit { get; set; }

        public int NumOfSeats { get; set; }
        public int SeatNumber { get; set; }

        public Composite(int numOfSeats, float baggageWeightLimit)
        {
            NumOfSeats = numOfSeats;
            BaggageWeightLimit = baggageWeightLimit;
            Components = new List<IComponent>();
        }

        public virtual void Add(IComponent component)
        {
            if (component is Passenger passenger && GetType() == passenger.TicketType)
            {
                if (BaggageWeightLimit <= BaggageWeight + component.BaggageWeight)
                {
                    throw new ArgumentException("Overweight!");
                }

                if (Components.Any(c => c.SeatNumber == component.SeatNumber))
                {
                    throw new ArgumentException($"Seat with number {component.SeatNumber} is taken!");
                }

                if (NumOfSeats < component.SeatNumber)
                {
                    throw new ArgumentException(
                        $"Current class {GetType()} does not have seat with number {component.SeatNumber}");
                }

                Components.Add(passenger);
            }
        }

        public void RemoveBaggage(int seatNumber)
        {
            if (GetType() == typeof(EconomyClass))
            {
                foreach (var c in Components)
                {
                    c.RemoveBaggage(seatNumber);
                }
            }
        }

        public IComponent DisembarkPassenger(int seatNumber, Type ticketType) 
        {
            IComponent passenger = null;
            if (this is Plane)
            {
                foreach (var component in Components)
                {
                    passenger = component.DisembarkPassenger(seatNumber, ticketType);
                }
            }
            else
            {
                if (GetType() == ticketType)
                {
                    passenger = Components.FirstOrDefault(x => x.SeatNumber == seatNumber);
                    Components.Remove(passenger);
                }
            }

            return passenger;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"{GetType().ToString().Split('.').Last()} info:");
            Console.WriteLine($"Baggage weight total: {BaggageWeight}/ max capacity: {BaggageWeightLimit}");
            Console.WriteLine(
                $"Number of seats total: {NumOfSeats}/ number of free seats: {NumOfSeats - Components.Count}");
            foreach (var component in Components)
            {
                component.PrintInfo();
            }
        }
    }
}