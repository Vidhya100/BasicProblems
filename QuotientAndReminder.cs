using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public static class QuotientAndReminder
    {
        public static void FindQuotientAndReminder()
        {
            int quoteint, reminder;
            Console.WriteLine("Enter the Divident: ");
            int divident = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            quoteint = divident / divisor;
            Console.WriteLine("Quoteint is: " + quoteint);

            reminder = divident % divisor;
            Console.WriteLine("Remider is: " + reminder);

        }
    }
}
