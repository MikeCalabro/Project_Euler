// Evaluate the sum of all the amicable numbers under 10,000

namespace ProjectEuler
{
    class Problem_21
    {
        public static int SumOfDivisors(int number)
        {
            int sum = 1;
            for(int i = 2; i < (number / 2) + 1; i++)
            {
                if(Problem_12.IsDivisor(number, i))
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static int AmicableSumUnder(int maxNumber = 10000)
        {
            int sum = 0;
            for(int a = 10; a < maxNumber; a++)
            {
                int b = SumOfDivisors(a);
                if((a == SumOfDivisors(b)) && a != b)
                {
                    sum += a;
                }
            }
            return sum;
        }
    }
}