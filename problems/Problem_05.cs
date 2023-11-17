// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

using System.Numerics;

namespace ProjectEuler
{
    public class Problem_05
    {
        public static bool IsNotEvenlyDivisible(long number, int multiple)
        {
            if(number % multiple != 0)
            {
                return true;
            }
            return false;
        }

        public static bool AreAllMultiples(long number, int max)
        {
            for(int i = 2; i <= max; i++)
            {
                if(IsNotEvenlyDivisible(number, i))
                {
                    return false;
                }
            }
            return true;
        }

        public static long BigMult(int number)
        {
            long max = 1;

            for(long i = 2; i <= number; i++)
            {
                max *= i;
            }

            return max;
        }

        public static long SmallestIntDivisibleBy(int number = 20)
        {
            long max = BigMult(number);

            for(long i = number; i < max; i++)
            {
                if(AreAllMultiples(i, number))
                {
                    return i;
                }
            }
            return max;
        }
    }
}