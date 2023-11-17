// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product.
// What is the value of this product?

using System;

namespace ProjectEuler
{
    class Problem_08
    {
        public static long GreatestProduct(int len = 13)
        {
            string numRaw = File.ReadAllText("problem_files/problem_08_number.txt");
            string[] numArr = numRaw.Split('\n');
            string num = String.Join(null,numArr);

            long product;
            long answer = 0;

            for(int i = 0; i < num.Length - len; i++)
            {
                product = 1;

                for(int j = 0; j < len; j++)
                {
                    product *= long.Parse(num[i+j].ToString());
                }

                if(product > answer)
                {
                    answer = product;
                }
            }

            return answer;
        }
    }
}
