// Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.

namespace ProjectEuler
{
    class Problem_23
    {
        public static bool IsAbundant(int number){
            if(Problem_21.SumOfDivisors(number) > number)
            {
                return true;
            }
            return false;
        }

        public static int[] AllAbundantNumbers(int limit = 28124)
        {
            int[] abundantNumbers = new int[8000];
            int counter = 0;
            for(int i = 10; i < limit; i++)
            {
                if(IsAbundant(i))
                {
                    abundantNumbers[counter] = i;
                    counter += 1;
                }
            }

            return abundantNumbers;
        }

        public static long AllAbundantSums()
        {
            int[] allAbundants = AllAbundantNumbers();
            bool[] allAbundantSums = new bool[28124*2];
            int check = 0;

            for(int i = 0; i < allAbundants.Length; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    check = allAbundants[i] + allAbundants[j];
                    if((check > allAbundants[i]) & (check > allAbundants[j]))
                    {
                        allAbundantSums[allAbundants[i] + allAbundants[j]] = true;
                    }          
                }
            }
            
            long solution = 0;
            for(int i = 1; i <= 28124; i++)
            {
                if(allAbundantSums[i] == false)
                {
                    solution += i;
                }
            }
            return solution;
        }
    }
}