using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public static class SwapNumbers
    {
        public static void SwapTheNumber()
        {
            Console.WriteLine("Enter 1st numbeer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());  //2

            Console.WriteLine("Enter 2nd Element: ");
            int num2 = Convert.ToInt32(Console.ReadLine());   //5
    
           //1st way
            num1 = num1 + num2;   //7
            num2 = num1 - num2;    //2
            num1 = num1 - num2;    //5

            Console.WriteLine("Afer swap: " + num1 + " " + num2);

            /*
            //2nd way

            num1 = num1 * num2; //10
            num2 = num1 / num2;  // 2
            num1 = num1 / num2; //5

            Console.WriteLine("After Swap num1 is {0} and num2 is {1}",num1, num2);*/
        }
    }
}
