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
    }
}