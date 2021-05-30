namespace Composite
{
    public class Primitive : IComponent
    {
        public float BaggageWeight { get; set; }
        
        public int SeatNumber { get; set; }

        public Primitive(float baggageWeight, int seatNumber)
        {
            BaggageWeight = baggageWeight;
            SeatNumber = seatNumber;
        }
        
        public void Add(IComponent component, string planePart)
        {
        }

        public void Remove(int seatNumber)
        {
            if (seatNumber == SeatNumber)
            {
                BaggageWeight = 0;
            }
            System.Console.WriteLine($"Baggage of passenger with {seatNumber} was taken off the plane.");
        }
    }
}