// What is the 10,0001st Prime Number?

namespace ProjectEuler
{
    public class Problem_07
    {
        public static int NthPrime(int n = 10001)
        {
            int numPrime = 1;
            int primeCheck = 1;

            while (numPrime < n)
            {
                primeCheck += 2;

                if(Problem_03.IsPrime(primeCheck))
                {
                    numPrime += 1;
                }
            }

            return primeCheck;
        }
    }
}