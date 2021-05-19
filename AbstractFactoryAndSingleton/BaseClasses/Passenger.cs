namespace AbstractFactoryAndSingleton.BaseClasses
{
    public abstract class Passenger
    {
        public int Money { get; protected set; }

        public int Pay(int price)
        {
            if (Money < 0)
            {
                return 0;
            }

            Money -= price;
            return price;
        }
    }
}