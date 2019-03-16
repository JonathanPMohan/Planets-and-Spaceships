using System;
using System.Collections.Generic;

namespace PlanetsAndSpacehips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // Create another List that contains that last two planet of our solar system // 
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

            // Create a dictionary that will hold the name of a spacecraft
            // that we have launched, and a list of names of the planets that it has visited
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
            // Add() Jupiter and Saturn at the end of the list. //
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // Combine the two lists by using AddRange() //
            planetList.AddRange(addPlanetList);

            // Use Insert() to add Earth, and Venus in the correct order //
            planetList.Insert(2, "Venus");
            planetList.Insert(3, "Earth");
            
            //Use Add() again to add Pluto to the end of the list
            planetList.Add("Pluto");

            // Now that all the planets are in the list, slice the list using GetRange() 
            //in order to extract the rocky planets into a new list called rockyPlanets
            var rockyPlanets = planetList.GetRange(0, 4);

            //Being good amateur astronomers, we know that Pluto is now a dwarf planet, 
            //so use the Remove() method to eliminate it from the end of planetList
            planetList.Remove("Pluto");

            // Iterate over your list of planets from above, and inside that loop,
            // iterate over the dictionary. Write to the console, for each planet,
            // which satellites have visited which planet.

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
