using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            Sphere redSphere = new Sphere(new Color(255, 0, 0), 5f);
            Sphere blueSphere = new Sphere(new Color(0, 0, 255), 3f);
            Sphere greenSphere = new Sphere(new Color(0, 255, 0), 4f);

            
            redSphere.Throw();
            redSphere.Throw();
            blueSphere.Throw();
            greenSphere.Throw();
            greenSphere.Throw();
            greenSphere.Throw();

            
            blueSphere.Pop();

            
            blueSphere.Throw();

            
            Console.WriteLine(redSphere);
            Console.WriteLine(blueSphere);
            Console.WriteLine(greenSphere);
        }
    }
}
