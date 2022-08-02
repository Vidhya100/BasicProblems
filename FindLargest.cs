using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public static class FindLargest
    {
        public static void FindAmongLargest()
        {
            Console.WriteLine("Enter three Numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("{0} is greater.", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("{0} is grater.", num2);

            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("{0} is greater.", num3);
            }
            else
            {
                Console.WriteLine("number is smaller.");
            }
        }
    }
}
