// Find the maximum total from top to bottom of the triangle attached (found in problem_files)

namespace ProjectEuler
{
    class Problem_18_67
    {
        public static int MaxVal(int a, int b)
        {
            if(a > b)
            {
                return a;
            }
            return b;
        }

        public static int LargestSequenceTotal(string problem = "problem_18")
        {
            string filePath = $"problem_files/{problem}_number.txt";
            string triangleRaw = File.ReadAllText(filePath);
            string[] triangleStrings = triangleRaw.Split('\n');
            int[][] triangle = new int[triangleStrings.Length][];
            
            for(int i = 0; i < triangleStrings.Length; i++)
            {
                triangle[i] = Array.ConvertAll(triangleStrings[i].Split(' '), int.Parse);
            }

            for(int i = 0; i < triangle[1].Length; i++)
            {
                triangle[1][i] += triangle[0][0];
            }

            for(int i = 2; i < triangle.Length; i++)
            {
                triangle[i][0] += triangle[i-1][0];
                triangle[i][^1] += triangle[i-1][^1];
                for(int j = 1; j < triangle[i].Length - 1; j++)
                {
                    triangle[i][j] += MaxVal(triangle[i-1][j-1], triangle[i-1][j]);
                }
            }
            
            int answer = triangle[^1].Max();
            return answer;
        }
    }
}