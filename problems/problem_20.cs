// Find the sum of the digits in the number 100!

using System.Numerics;

namespace ProjectEuler
{
    class Problem_20
    {
        public static BigInteger Factorial(int factBase = 5)
        {
            if(factBase == 1)
            {
                return 1;
            }

            return factBase * Factorial(factBase - 1);
        }
        public static int FactorialDigitSum(int factBase = 100)
        {
            BigInteger factorial = Factorial(factBase);
            int sum = 0;

            string fullNumString = factorial.ToString();
            
            for(int i = 0; i < fullNumString.Length; i++)
            {
                sum += int.Parse(fullNumString[i].ToString());
            }

            return sum;
        }
    }
}