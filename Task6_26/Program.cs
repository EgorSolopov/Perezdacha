using System;
using System.Collections.Generic;

namespace Task6_26
{
    class Program
    {
        static void Main(string[] args)
        {
            RedGiantStar rgs1 = new RedGiantStar(10e12, 10e9, 6666, "Red", 3);
            RedGiantStar rgs2 = new RedGiantStar(10e4, 10e14, 4562, "Dark Red", 2);
            RedGiantStar rgs3 = new RedGiantStar(10e23, 10e3, 12456, "Red", 1);
            RedGiantStar rgs4 = new RedGiantStar(10e4, 10e7, 47888, "Bright Red", 3);
            RedGiantStar rgs5 = new RedGiantStar(10e14, 10e10, 273, "Dark Red", 5);

            List<ISpaceObject> spaceObjects = new List<ISpaceObject>();

            spaceObjects.Add(rgs1);
            spaceObjects.Add(rgs2);
            spaceObjects.Add(rgs3);
            spaceObjects.Add(rgs4);
            spaceObjects.Add(rgs5);

            foreach (var spObj in spaceObjects)
            {
                Console.WriteLine(spObj.GetInfoAboutSpaceObject() + " Star density: " + spObj.CalcDensity());
                Console.WriteLine();
            }
        }
    }
}