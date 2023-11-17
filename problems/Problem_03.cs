// What is the largest prime factor of the number 600851475143?

using System.Numerics;

namespace ProjectEuler
{
    public class Problem_03
    {
        public static bool IsPrime(long number)
        {
            if(number == 2)
            {
                return true;
            }

            for(int i=2; i<Math.Sqrt(number)+1; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int LargestPrimeFactor(long number = 600851475143) 
        {
            int largest = 1;

            for(int i=2; i<Math.Sqrt((double)number)+1; i++)
            {
                if(number % i == 0 && IsPrime(i))
                {
                    largest = i;
                }
            }

            return largest;
        }
    }
}
