using AbstractFactoryAndSingleton.BaseClasses;

namespace AbstractFactoryAndSingleton
{
    public class TaxiFactory : VehicleFactory
    {
        public override Vehicle GetVehicle()
        {
            return new Taxi();
        }
    }
}