// Find the sum of the digits of 2^1000

using System;
using System.Numerics;

namespace ProjectEuler
{
    class Problem_16
    {
        public static int PowerDigitSum(int numBase = 2, int numExponent = 1000)
        {
            int sum = 0;
            BigInteger fullNumber = BigInteger.Pow(new BigInteger(numBase), numExponent);
            string fullNumString = fullNumber.ToString();
            
            for(int i = 0; i < fullNumString.Length; i++)
            {
                sum += int.Parse(fullNumString[i].ToString());
            }

            return sum;
        }
    }
}