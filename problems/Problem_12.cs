// What is the value of the first triangle number to have over five hundred divisors?

using System;

namespace ProjectEuler
{
    class Problem_12
    {
        public static bool IsDivisor(long number, long multiple)
        {
            if(number % multiple == 0){
                return true;
            }
            return false;
        }

        public static long TriangleNumberWithDivisorsOver(long minNumberOfDivisors = 500)
        {
            long triangleNumber = 0;
            long adder = 1;
            long numDivisors = 0;

            while(numDivisors < minNumberOfDivisors )
            {
                triangleNumber += adder;
                numDivisors = 0;
                for(long i = 1; i <= (long)Math.Sqrt(triangleNumber); i++)
                {
                    if(IsDivisor(triangleNumber, i))
                    {
                        numDivisors += 1;
                    }
                }
                numDivisors *= 2;
                adder += 1;
            }
            return triangleNumber;
        }
    }
}