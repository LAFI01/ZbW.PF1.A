using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB12
{
    public static class Fibonacci
    {

        public static int FibonacciIterativ(int n)
        {
            if (n <= 1)
                return n;

            int previousNumber = 0;
            int currentNumber = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = previousNumber + currentNumber;
                previousNumber = currentNumber;
                currentNumber = result;
            }

            return result;
        }
    }
}
