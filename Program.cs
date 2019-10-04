using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> planetList2 = new List<string>() { "Neptune", "Uranus" };


            planetList.AddRange(planetList2);
            planetList.Insert(3, "Earth");
            planetList.Insert(4, "Venus");
            planetList.Add("Pluto");

            Console.WriteLine("-------Rocky Plizzies------");
            List<string> rockyPlanets = planetList.GetRange(0, 5);

            foreach (string planet in rockyPlanets)
            {

                Console.WriteLine(planet);
            }
        planetList.Remove("Pluto");
        foreach (string planet in planetList) 
        {
            Console.WriteLine(planet);
        }
        }
    }
}
    
