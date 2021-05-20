using System;
using System.Collections.Generic;
using System.Linq;
using AbstractFactoryAndSingleton.BaseClasses;

namespace AbstractFactoryAndSingleton
{
    public class Station
    {
        private static Station _station;
        private readonly VehicleFactory _busFactory;
        private readonly VehicleFactory _taxiFactory;
        private readonly PassengerFactory _passengerFactory;
        private readonly DriverFactory _taxiDriverFactory;
        private readonly DriverFactory _busDriverFactory;
        private readonly List<Vehicle> _vehicles;
        private readonly List<Driver> _drivers;
        
        public static Station GetStation()
        {
            return _station ??= new Station();
        }
        private Station()
        {
            _vehicles = new List<Vehicle>();
            _drivers = new List<Driver>();
            _busFactory = new BusFactory();
            _taxiFactory = new TaxiFactory();
            _passengerFactory = new PassengerFactory();
            _taxiDriverFactory = new TaxiDriverFactory();
            _busDriverFactory = new BusDriverFactory();
        }

        public void MakeDefaultBus()
        {
            _vehicles.Add(_busFactory.GetVehicle());
        }
        
        public void MakeDefaultTaxi()
        {
            _vehicles.Add(_taxiFactory.GetVehicle());
        }

        public AbstractFactoryAndSingleton.Passenger MakeDefaultPassenger()
        {
            return _passengerFactory.GetPassenger();
        }

        public void MakeDefaultTaxiDriver()
        {
            _drivers.Add(_taxiDriverFactory.GetDriver());
        }
        
        public void MakeDefaultBusDriver()
        {
            _drivers.Add(_busDriverFactory.GetDriver());
        }

        public bool EmbusDriversToVehicles()
        {
            if (!_drivers.Any())
            {
                return false;
            }

            foreach (var vehicle in _vehicles)
            {
                var driver = _drivers.FirstOrDefault(d => d.GetType() == vehicle.DriverType);
                if (driver == null)
                {
                    return false;
                }
                vehicle.Embus(driver);
            }
            
            return true;
        }
        
        public bool EmbusPassenger<TVehicle>(AbstractFactoryAndSingleton.Passenger passenger)
        {
            var taxi = _vehicles.FirstOrDefault(v => v.GetType() == typeof(TVehicle) && v.Passengers.Count < v.Capacity);
            
            if (taxi == null)
                return false;
            try
            {
                taxi.Embus(passenger);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
            return true;
        }

        public void LaunchVehicles()
        {
            foreach (var vehicle in _vehicles)
            {
                vehicle.Launch();
            }
        }
    }
}