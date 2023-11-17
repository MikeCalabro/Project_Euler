// Find the sum of all the multiples of 3 or 5 below 1000

namespace ProjectEuler
{
    public class Problem_01
    {
        public static int ThreeOrFive(int max_num = 1000) 
        {
            int sum = 0;

            for(int i = 0; i < max_num; i++) 
            {
                if(i % 3 == 0 || i % 5 == 0) 
                {
                    sum += i;
                }
            }
            
            return sum;
        }
    }
}
