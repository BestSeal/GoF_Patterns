namespace BuilderPattern
{
    public class BusBuilder : VehicleBuilder
    {
        public BusBuilder() : base(new Bus())
        {
            
        }

        public override void Restart()
        {
            Vehicle = new Bus();
        }

        public override void SetCapacity()
        {
            Vehicle.Capacity = 30;
        }

        public override void SetDriver()
        {
            Vehicle.Embus(new BusDriver());
        }

        public override void SetPrice()
        {
            Vehicle.Price = 15;
        }
    }
}