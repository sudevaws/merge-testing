using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrplanets = { "Mercury", "Venus", "Earth", "Mars", "jupiter", "saturn", "uranus", "neptune", };
            
            foreach (var planet in arrplanets)
            {
                Console.WriteLine(planet);
            }
            Console.WriteLine("\n\nMonths of the year using for loop:");
            for(int i=0;i<arrplanets.Length;i++)
            {
                Console.WriteLine(arrplanets[i]);
            }
            Console.ReadKey();
        }
    }
}
