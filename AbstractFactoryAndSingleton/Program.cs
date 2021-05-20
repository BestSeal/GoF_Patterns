using System;

namespace AbstractFactoryAndSingleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var station = Station.GetStation();
            
            station.MakeDefaultBus();
            
            station.MakeDefaultTaxi();
            station.MakeDefaultTaxi();
            
            station.MakeDefaultBusDriver();
            station.MakeDefaultBusDriver();
            
            station.MakeDefaultTaxiDriver();
            station.MakeDefaultTaxiDriver();
            
            station.LaunchVehicles();
            
            for (int i = 0; i < 5; ++i)
            {
                if (!station.EmbusPassenger<Taxi>(station.MakeDefaultPassenger()))
                {
                    Console.WriteLine("No available taxi left, make a new one.");
                }
            }
            
            for (int i = 0; i < 30; ++i)
            {
                if (!station.EmbusPassenger<Bus>(station.MakeDefaultPassenger()))
                {
                    Console.WriteLine("No available taxi left, make a new one.");
                }
            }
            
            station.LaunchVehicles();
            station.EmbusDriversToVehicles();
            station.LaunchVehicles();
        }
    }
}