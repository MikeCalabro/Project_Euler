// What is the sum of the numbers on the diagonals in a 1,001 by 1,001 spiral

namespace ProjectEuler
{
    class Problem_28
    {
        public static long NumberSpiralDiagonalSum(int size = 1001)
        {
            long sum = 0;
            long diagNum = 1;
            long increment = 2;
            int corner = 0;
            int currentSize = 1;
            while(currentSize < size)
            {
                sum += diagNum;
                diagNum += increment;
                corner += 1;
                if(corner == 4)
                {
                    corner = 0;
                    increment += 2;
                    currentSize += 2;
                }
            }
            sum += diagNum;
            return sum;
        }
    }
}