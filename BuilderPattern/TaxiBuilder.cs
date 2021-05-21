namespace BuilderPattern
{
    public class TaxiBuilder : VehicleBuilder
    {
        public TaxiBuilder() : base(new Taxi())
        {
            
        }

        public override void SetChildChair()
        {
            (Vehicle as Taxi).ChildChair = true;
        }

        public override void Restart()
        {
            Vehicle = new Taxi();
        }

        public override void SetCapacity()
        {
            Vehicle.Capacity = 4;
        }

        public override void SetDriver()
        {
            Vehicle.Embus(new TaxiDriver());
        }

        public override void SetPrice()
        {
            Vehicle.Price = 20;
        }
    }
}