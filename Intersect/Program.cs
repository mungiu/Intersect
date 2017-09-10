using System;
using System.Collections.Generic;
using System.Linq;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            string[] citiesInUk =
            {
                "Sheffield", "Ripon", "Truro", "Manchester"
            };

            //modifies set -> finds values that are only in the first collection
            bigCities.ExceptWith(citiesInUk);
            foreach (string cityE in bigCities)
                Console.WriteLine(cityE);
            Console.WriteLine();

            ////modifies set -> finds values that are only in one collection
            //bigCities.SymmetricExceptWith(citiesInUk);
            //foreach (string cityS in bigCities)
            //    Console.WriteLine(cityS);
            //Console.WriteLine();

            ////modifies set -> returns values that are in EITHER collection
            //bigCities.UnionWith(citiesInUk);
            //foreach (string cityB in bigCities)
            //    Console.WriteLine(cityB);
            //Console.WriteLine();

            ////LINQ - performance intensive
            ////returns new IEnumerable interface, works any collection
            //var newCities = bigCities.Intersect(citiesInUk);
            //foreach (string city in newCities)
            //    Console.WriteLine(city);

            ////modifies the set -> assigns param values of intersecting variables 
            ////can take any collection with hashsets as parameters
            //bigCities.IntersectWith(citiesInUk);
            //foreach (string city in bigCities)
            //    Console.WriteLine(city);
        }
    }
}
