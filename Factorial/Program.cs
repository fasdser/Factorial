using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(6));
            Console.ReadLine();
        }

        public static int factorial(int n)
        {

            if (n == 1 || n == 0)
            {
                return 1;
            }

            var a = n;
            for (int i = 1; i < n; i++)
            {
                a *= n-i;               
            }
            return a;
        }

        public static int factorial1(int n) => (n == 0) ? 1 : n * factorial(n - 1);

        public static int factorial2(int n)
        {
            return n < 2 ? 1 : n * factorial(n - 1);
        }
    }
}
