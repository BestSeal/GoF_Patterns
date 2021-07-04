namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane = GetDefaultPlane();
            plane.Add(new Passenger(1, 10, typeof(EconomyClass)));
            plane.Add(new Passenger(1, 10, typeof(BusinessClass)));
            plane.Add(new Passenger(1, 10, typeof(FirstClass)));
            plane.PrintInfo();
            plane.DisembarkPassenger(1, typeof(EconomyClass));
            plane.PrintInfo();

        }

        private static Plane GetDefaultPlane()
        {
            var plane = new Plane();
            plane.Add(new Crew(2, 6));
            plane.Add(new Pilot());
            plane.Add(new Pilot());
            for (int i = 0; i < 6; i++)
            {
                plane.Add(new Stewardess());
            }
            
            plane.Add(new BusinessClass(20, 20 * 35));
            plane.Add(new FirstClass(10, 10 * 60));
            plane.Add(new EconomyClass(150, 150 * 20));

            return plane;
        }
    }
}