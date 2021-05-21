namespace BuilderPattern
{
    public abstract class Passenger
    {
        protected Passenger(float money)
        {
            Money = money;
        }
        public float Money { get; protected set; }
        
        public float Pay(float price)
        {
            if (Money < price) return 0;
            Money -= price;
            
            return price;
        }
    }
}