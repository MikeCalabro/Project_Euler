// Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.

using System.Numerics;

namespace ProjectEuler
{
    class Problem_13
    {
        public static string FirstDigits(int digits = 10)
        {
            string filePath = "problem_files/problem_13_number.txt";
            string numbersRaw = File.ReadAllText(filePath);
            string[] numbers = numbersRaw.Split('\n');

            BigInteger sum = new(0);

            for(int i = 0; i < numbers.Length; i++)
            {
                sum += BigInteger.Parse(numbers[i]);
            }
            
            return sum.ToString()[..digits];
        }
    }
}