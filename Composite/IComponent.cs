using System;

namespace Composite
{
    public interface IComponent
    {
        public float BaggageWeight { get; set; }
        
        public float BaggageWeightLimit { get; set; }
        
        public int NumOfSeats { get; set; }

        public int SeatNumber { get; set; }

        public void Add(IComponent component);
        
        public void RemoveBaggage(int seatNumber);
    }
} 