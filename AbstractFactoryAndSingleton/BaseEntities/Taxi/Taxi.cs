using System;
using AbstractFactoryAndSingleton.BaseClasses;

namespace AbstractFactoryAndSingleton
{
    public class Taxi : Vehicle
    {
        public Taxi(int capacity = 4, float price = 25) : base(capacity, price, typeof(TaxiDriver))
        {
            
        }
        
        public override void Embus(Driver driver)
        {
            if (driver is TaxiDriver)
            {
                Driver = driver;
            }
            else
            {
                throw new Exception($"Not supported driver type, {nameof(TaxiDriver)} expected");
            }
        }
    }
}