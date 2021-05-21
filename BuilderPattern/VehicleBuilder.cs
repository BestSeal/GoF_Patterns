namespace BuilderPattern
{
    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; protected set; }

        public VehicleBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public abstract void Restart();

        public abstract void SetCapacity();

        public abstract void SetDriver();

        public virtual void SetChildChair()
        {
            
        }

        public abstract void SetPrice();
        

    }
}