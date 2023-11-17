using System;

namespace ProjectEuler
{
    class Problem_09
    {
        public static int Triple(int sum = 1000)
        {
            int c;
            for(int a = 3; a < sum; a++)
            {
                for(int b = a + 1; b < sum; b++)
                {
                    c = 1000 - (a + b);
                    long aSquared = (long)Math.Pow(a, 2);
                    long bSquared = (long)Math.Pow(b, 2);
                    long cSquared = (long)Math.Pow(c, 2);

                    if(aSquared + bSquared == cSquared)
                    {
                        return a*b*c;
                    }
                } 
            }
            return 0;
        }
    }
}