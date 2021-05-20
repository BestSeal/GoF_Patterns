namespace AbstractFactoryAndSingleton
{
    public class Passenger
    {
        public Passenger(float money = 25)
        {
            Money = money;
        }
        public float Money { get; protected set; }

        public float Pay(float price)
        {
            if (Money < 0) return 0;

            Money -= price;
            return price;
        }
    }
}