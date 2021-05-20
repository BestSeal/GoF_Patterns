using AbstractFactoryAndSingleton.BaseClasses;

namespace AbstractFactoryAndSingleton
{
    public class BusDriverFactory : DriverFactory
    {
        public override Driver GetDriver()
        {
            return new BusDriver();
        }
    }
}