// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms

using System.Numerics;

namespace ProjectEuler
{
    public class Problem_02
    {
        public static int EvenFibSum(int maxNum = 4000000)
        {
            int sum = 0;

            int tmp = 0;
            int n1 = 1;
            int n2 = 2;

            while(n2 <= maxNum)
            {
                if(n2 % 2 == 0)
                {
                    sum += n2;
                }

                tmp = n2;
                n2 += n1;
                n1 = tmp;
            }
            
            return sum;
        }   
    }
}
