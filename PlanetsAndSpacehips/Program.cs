using System;
using System.Collections.Generic;

namespace PlanetsAndSpacehips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            List<string> addPlanetList = new List<string>() { "Uranus", "Neptune" };

            var mercuryProbes = new List<string>() { "Mariner", "Messenger" };
            var venusProbes = new List<string>() { "Mariner 2", "Venera 7", "Vega Spacecraft" };
            var earthProbes = new List<string>() { "Mariner 10", "Pioneer 10", "Pioneer 11" };
            var marsProbes = new List<string>() { "Mars Global Surveyor", "Viking 1", "Viking 2" };
            var jupiterProbes = new List<string>() { "Pioneer 10", "Galileo", "Pioneer 11" };
            var saturnProbes = new List<string>() { "Voyager 1", "Voyager 2", "Pioneer 11" };
            var uranusProbes = new List<string>() { "Voyager 2" };
            var neptuneProbes = new List<string>() { "Voyager 2" };
            var plutoProbes = new List<string>() { "New Horizons" };

            var solarSystemProbes = new Dictionary<string, List<string>>()
            {
                { "Mercury", mercuryProbes },
                { "Venus" , venusProbes },
                { "Earth", earthProbes },
                { "Mars", marsProbes },
                { "Jupiter", jupiterProbes },
                { "Saturn", saturnProbes },
                { "Uranus", uranusProbes },
                { "Neptune", neptuneProbes },
                { "Pluto", plutoProbes }
            };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.AddRange(addPlanetList);

            planetList.Insert(2, "Venus");
            planetList.Insert(3, "Earth");

            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            foreach (string planet in planetList)
            {
                foreach (var (key, value) in solarSystemProbes)
                {
                    if (planet == key)
                    {
                        foreach (string satellite in value)
                            Console.WriteLine($"{satellite} visited {planet}.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
