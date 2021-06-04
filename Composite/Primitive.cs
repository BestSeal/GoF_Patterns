using System;

namespace Composite
{
    public abstract class Primitive : IComponent
    {
        public float BaggageWeight { get; set; }
        public float BaggageWeightLimit { get; set; }
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
    }
}