using AbstractFactoryAndSingleton.BaseClasses;

namespace AbstractFactoryAndSingleton.Implementations
{
    public class BusPassenger : Passenger
    {
        public BusPassenger(int money)
        {
            Money = money;
        }
    }
}