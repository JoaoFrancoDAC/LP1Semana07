using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Color { get; }
        public float Radius { get; private set; }
        public int TimesThrown { get; private set; }

        public Sphere(Color color, float radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                TimesThrown++;
            }
        }

        public override string ToString()
        {
            return $"Sphere: Color(R:{Color.Red},G:{Color.Green},B:{Color.Blue},A:{Color.Alpha}), Radius:{Radius}, Times Thrown:{TimesThrown}";
        }
    }
}