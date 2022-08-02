using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
   public static class EvenOrOdd
    {
        public static void CheckEvenOdd()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Given number {0} is even.", num);
            }
            else
            {
                Console.WriteLine("Given number {0} is odd.", num);
            }
        }
    }
}
