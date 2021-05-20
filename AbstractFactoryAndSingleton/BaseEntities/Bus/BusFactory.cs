using AbstractFactoryAndSingleton.BaseClasses;

namespace AbstractFactoryAndSingleton
{
    public class BusFactory : VehicleFactory
    {
        public override Vehicle GetVehicle()
        {
            return new Bus();
        }
    }
}