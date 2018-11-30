using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nth = 10001;
            int count = 0;
            long i = 2;
            while(count <= nth)
            {

                if (isPrime(i))
                {
                    count++;
                }
                if (count == nth)
                {
                    Console.WriteLine(nth + "th prime is " + i);
                    Console.ReadLine();
                }
                i++;
            }


            Console.WriteLine(isPrime(21));
            Console.ReadLine();
        }

        public static bool isPrime(long num)
        {
            if (num == 2 || num == 3)
                return true;

            if (num % 2 == 0)
                return false;

            for (long i = 3; i < num; i = i + 2)
            {
                if (num % i == 0)
                    return false;

            }
            return true;
        }
    }
}
