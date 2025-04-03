using System;

namespace BetterColorSpheres
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

            
            Console.WriteLine($"Red sphere color: R:{redSphere.Color.Red}, G:{redSphere.Color.Green}, B:{redSphere.Color.Blue}");
            Console.WriteLine($"Blue sphere radius: {blueSphere.Radius}");
            Console.WriteLine($"Green sphere times thrown: {greenSphere.TimesThrown}");
            Console.WriteLine($"Green sphere grey value: {greenSphere.Color.GetGrey}");
        }
    }
}