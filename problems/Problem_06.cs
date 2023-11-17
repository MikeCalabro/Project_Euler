// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

namespace ProjectEuler
{
    public class Problem_06
    {
        public static long SumOfSquares(long maxNumber)
        {
            long answer = 0;

            for(long i = 1; i <= maxNumber; i++)
            {
                answer += (long)Math.Pow(i, 2);
            }

            return answer;
        }

        public static long SquareOfSums(long maxNumber)
        {
            long answer = 0;
            long sum = 0;

            for(long i = 1; i <= maxNumber; i++)
            {
                sum += i;
            }
            
            answer = (long)Math.Pow(sum, 2);
            return answer;
        }

        public static long SquareMinusSums(long number = 100)
        {
            long answer = SquareOfSums(number) - SumOfSquares(number);

            return answer;
        }
    }
}