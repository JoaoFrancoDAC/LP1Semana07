using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private float radius;
        private int timesThrown;

        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.timesThrown = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return timesThrown;
        }

        public override string ToString()
        {
            return $"Sphere: Color(R:{color.Red},G:{color.Green},B:{color.Blue},A:{color.Alpha}), Radius:{radius}, Times Thrown:{timesThrown}";
        }
    }
}