namespace AbstractFactoryAndSingleton
{
    public class TaxiDriverFactory: DriverFactory
    {
        public override Driver GetDriver()
        {
            return new TaxiDriver();
        }
    }
}