using System;
using System.Collections;
using System.Linq;

namespace Composite
{
    public class Crew : Composite
    {
        private int NumOfPilots { get; set; }
        private int NumOfStewardess { get; set; }
        public Crew(int numOfPilots, int numOfStewardess) : base(0, 0)
        {
            NumOfPilots = numOfPilots;
            NumOfStewardess = numOfStewardess;
        }

        public override void Add(IComponent component)
        {
            if (component is Pilot && Components.Count(c => c is Pilot) < 2)
            {
                Components.Add(component);
            }
            
            if (component is Stewardess && Components.Count(c => c is Stewardess) < 6)
            {
                Components.Add(component);
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Crew on board:\nPilots - {NumOfPilots}\nStewardesses - {NumOfStewardess}");
        }
    }
}