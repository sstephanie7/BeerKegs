using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;
            string biggestKegName = "";
            for (int i = 0; i < nLines; i++)
            {

                string modelOfKeg = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volumeOfCurrentKeg = Math.PI * Math.Pow(radius, 2) * height;

                if (volumeOfCurrentKeg > biggestKeg)
                {
                    biggestKeg = volumeOfCurrentKeg;
                    biggestKegName = modelOfKeg; 
                }
            }
            Console.WriteLine(biggestKegName);

        }
    }
}
