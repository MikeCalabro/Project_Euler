// Find the sum of all the primes below two million.

using System;

namespace ProjectEuler
{
    class Problem_10
    {
        public static long PrimeSumBelowNum(int number = 2000000)
        {
            long sum = 2;

            for(long i = 3; i < number; i+=2)
            {
                if(Problem_03.IsPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
