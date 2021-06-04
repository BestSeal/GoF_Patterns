using System;

namespace Composite
{
    public class Passenger : Primitive
    {
        public Type TicketType { get; set; }
        
        public Passenger(int seatNumber, float baggageWeight, Type ticketType) : base(seatNumber, baggageWeight)
        {
            TicketType = ticketType;
            if (baggageWeight > 60)
            {
                throw new ArgumentException("Overweight!");
            }
        }
    }
}