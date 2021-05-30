using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Composite
{
    public class Composite : IComponent
    {
        private readonly List<IComponent> _components;

        public string PlanePart { get; private set; }

        public float BaggageWeight
        {
            get
            {
                float weight = 0;
                foreach (var c in _components)
                {
                    weight += c.BaggageWeight;
                }

                return weight;
            }

            set
            {
                
            }

        }
        
        public int SeatNumber { get; set; }

        public Composite(string planePart)
        {
            PlanePart = planePart;
            _components = new List<IComponent>();
        }
        
        public void Add(IComponent component, string planePart)
        {
            if (PlanePart == planePart)
            {
                _components.Add(component);
            }
            else
            {
                foreach (var c in _components)
                {
                    c.Add(component, planePart);
                }
            }

        }

        public void Remove(int seatNumber)
        {
            foreach (var c in _components)
            {
                c.Remove(seatNumber);
            }
        }
    }
}