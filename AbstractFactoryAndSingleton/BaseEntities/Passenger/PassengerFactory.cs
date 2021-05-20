namespace AbstractFactoryAndSingleton
{
    public class PassengerFactory
    {
        public AbstractFactoryAndSingleton.Passenger GetPassenger()
        {
            return new AbstractFactoryAndSingleton.Passenger();
        }
    }
}