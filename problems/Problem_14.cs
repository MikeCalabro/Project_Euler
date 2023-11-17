// Question

using System;

namespace ProjectEuler
{
    class Problem_14
    {
        public static long LongestCollatzChain(long maxStartingNumber = 1000000)
        {
            long collatzNum = 2;
            long longestChain = 0;
            long counter = 0;
            long answer = 1;

            for(long i = 2; i < maxStartingNumber; i++)
            {
                counter = 1;
                collatzNum = i;
                while(collatzNum != 1)
                {
                    if(collatzNum % 2 == 0)
                    {
                        collatzNum /= 2;
                    }
                    else
                    {
                        collatzNum = (3 * collatzNum) + 1;
                    }
                    counter += 1;
                }
                if(counter > longestChain)
                {
                    longestChain = counter;
                    answer = i;
                }
            }

            return answer;
        }
    }
}