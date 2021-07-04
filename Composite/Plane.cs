using System;

namespace Composite
{
    public class Plane : Composite
    {
        public Plane() : base(0, 0)
        {
        }

        public override void Add(IComponent component)
        {
            if (component is BusinessClass or FirstClass or EconomyClass or Crew)
            {
                Components.Add(component);
            }
            else
            {
                foreach (var c in Components)
                {
                   c.Add(component); 
                }
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Plane info.");
            foreach (var component in Components)
            {
                component.PrintInfo();
            }
        }
    }
}