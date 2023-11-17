// Find the largest palindrome made from the product of two 3-digit numbers

namespace ProjectEuler
{
      public class Problem_04
    {
        public static bool IsPalindrome(int number)
        {
            string numString = number.ToString();
            for(int i = 0; i <= numString.Length/2; i++)
            {
                if (numString[i] != numString[^(i+1)]){
                    return false;
                }
            }
            return true;
        }

        public static int LargestPalindromeProduct(int digits = 3)
        {
            int answer = 0;

            int max =  (int)Math.Pow(10,digits);
            int min =  (int)Math.Pow(10,digits-1);
            int check = 0;

            for(int i=min; i< max; i++)
            {
                for(int j=min; j< max; j++)
                {
                    check = i*j;

                    if(check > answer & IsPalindrome(i*j))
                    {
                        answer = check;
                    }
                }
            }
            return answer;
        }
    }
}
