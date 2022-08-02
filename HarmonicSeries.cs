using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public static class HarmonicSeries
    {
        public static void FindHarmonicSeries()
        {
            double H = 1;
            Console.WriteLine("Enter the number to print harmonic series ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N != 0)
            {
                for (int i = 2; i <= N; i++)
                {
                    H += 1 / (double)i;

                }
            }
            else
            {
                Console.WriteLine("give value other than 0 .");
            }
            Console.WriteLine("Harmonic value  " + H);
        }
    }
}
