namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            var taxiBuilder = new TaxiBuilder();
            var busBuilder = new BusBuilder();
            var director = new Director();
            
            director.Construct(taxiBuilder);

            var taxi1 = taxiBuilder.Vehicle;
            taxi1.Start();
            
            taxi1.Embus(new AdultPassenger());
            taxi1.Embus(new ChildPassenger());
            taxi1.Embus(new ChildPassenger());
            taxi1.Embus(new AdultPassenger());
            taxi1.Embus(new AdultPassenger());
            taxi1.Embus(new AdultPassenger());
            
            taxi1.Start();
            
            director.Construct(busBuilder);

            var bus1 = busBuilder.Vehicle;
            bus1.Start();
            
            bus1.Embus(new AdultPassenger());
            bus1.Embus(new ChildPassenger());
            bus1.Embus(new ChildPassenger());
            bus1.Embus(new AdultPassenger());
            bus1.Embus(new AdultPassenger());
            bus1.Embus(new AdultPassenger());
            bus1.Embus(new PrivilegedPassenger());
            bus1.Embus(new PrivilegedPassenger());
            bus1.Embus(new PrivilegedPassenger());
            
            bus1.Start();
            

        }
    }
}