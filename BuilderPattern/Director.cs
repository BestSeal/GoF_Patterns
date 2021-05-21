namespace BuilderPattern
{
    public class Director
    {
        private VehicleBuilder VehicleBuilder { get; set; }


        public void Construct(VehicleBuilder vehicleBuilder)
        {
            VehicleBuilder = vehicleBuilder;
            VehicleBuilder.SetCapacity();
            VehicleBuilder.SetDriver();
            VehicleBuilder.SetPrice();
            VehicleBuilder.SetChildChair();
        }
    }
}