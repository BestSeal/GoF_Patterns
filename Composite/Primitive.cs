using System;

namespace Composite
{
    public abstract class Primitive : IComponent
    {
        private float _baggageWeightLimit;
        public float BaggageWeight { get; set; }

        public float BaggageWeightLimit
        {
            get => 0;
            set => _baggageWeightLimit = value;
        }

        public int NumOfSeats { get; set; }
        public int SeatNumber { get; set; }

        public Primitive(int seatNumber, float baggageWeight)
        {
            SeatNumber = seatNumber;
            BaggageWeight = baggageWeight;
        }
        public void Add(IComponent component)
        {
        }

        public void RemoveBaggage(int seatNumber)
        {
            if (SeatNumber == seatNumber)
            {
                BaggageWeight = 0;
            }
        }

        public IComponent DisembarkPassenger(int seatNumber, Type ticketType)
        {
            return this;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Seat number: {SeatNumber}, baggage weight: {BaggageWeight};");
        }
    }
}