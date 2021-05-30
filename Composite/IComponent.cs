namespace Composite
{
    public interface IComponent
    {
        public float BaggageWeight { get; set; }

        public int SeatNumber { get; set; }

        public void Add(IComponent component, string planePart);

        public void Remove(int seatNumber);
    }
}