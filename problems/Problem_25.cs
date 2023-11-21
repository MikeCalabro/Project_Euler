// What is the index of the first term in the Fibonacci sequence to contain 1,000 digits?

using System.Numerics;

namespace ProjectEuler
{
    class Problem_25
    {
        public static int FibonacciLengthByIndex(int length = 1000)
        {
            int ind = 2;
            BigInteger tmp = new(0);
            BigInteger n1 = new(1);
            BigInteger n2 = new(1);

            while(n2.ToString().Length < length)
            {
                tmp = n2;
                n2 += n1;
                n1 = tmp;
                ind++;
            }

            return ind;
        }
    }
}