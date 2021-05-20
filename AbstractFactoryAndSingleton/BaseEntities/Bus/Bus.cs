using System;
using AbstractFactoryAndSingleton.BaseClasses;

namespace AbstractFactoryAndSingleton
{
    public class Bus : Vehicle
    {
        public Bus(int capacity = 40, float price = 10) : base(capacity, price, typeof(BusDriver))
        {
        }

        public override void Embus(Driver driver)
        {
            if (driver is BusDriver)
            {
                Driver = driver;
            }
            else
            {
                throw new Exception($"Not supported driver type, {nameof(BusDriver)} expected");
            }
        }
    }
}