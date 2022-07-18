using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Prime Number
            int num;
            Console.WriteLine("Enter a Number:");
            num = Convert.ToInt32(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (num % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime? " + prime);

            Console.ReadKey();
        }
    }
}
