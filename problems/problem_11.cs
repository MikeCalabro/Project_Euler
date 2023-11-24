// What is the greatest product of four adjacent numbers in the same direction in the 20x20 grid

namespace ProjectEuler
{
    class Problem_11
    {
        public static long GreatestAdjacentProduct(string problem = "problem_11")
        {
            long product = 0;
            long check = 1;
            string rawGrid = File.ReadAllText($"problem_files/{problem}_number.txt");
            string[] gridStrings = rawGrid.Split('\n');
            int[][] grid = new int[gridStrings.Length][];

            for(int i = 0; i < gridStrings.Length; i++)
            {
                grid[i] = Array.ConvertAll(gridStrings[i].Split(' '), int.Parse);
            }

            for(int i = 0; i < gridStrings.Length; i++)
            {
                for(int j = 0; j < grid[0].Length - 4; j++)
                {
                     check = 1;
                     for(int n = 0; n < 4; n++)
                     {
                        check *= grid[i][j + n];
                        if(check > product)
                        {
                            product = check;
                        }
                     }
                }
            }

            for(int i = 0; i < gridStrings.Length - 4; i++)
            {
                for(int j = 0; j < grid[0].Length; j++)
                {
                     check = 1;
                     for(int n = 0; n < 4; n++)
                     {
                        check *= grid[i + n][j];
                        if(check > product)
                        {
                            product = check;
                        }
                     }
                }
            }

            for(int i = 0; i < gridStrings.Length - 4; i++)
            {
                for(int j = 0; j < grid[0].Length - 4; j++)
                {
                     check = 1;
                     for(int n = 0; n < 4; n++)
                     {
                        check *= grid[i + n][j + n];
                        if(check > product)
                        {
                            product = check;
                        }
                     }
                }
            }

            for(int i = 0; i < gridStrings.Length - 4; i++)
            {
                for(int j = 3; j < grid[0].Length; j++)
                {
                     check = 1;
                     for(int n = 0; n < 4; n++)
                     {
                        check *= grid[i + n][j - n];
                        if(check > product)
                        {
                            product = check;
                        }
                     }
                }
            }

            return product;
        }
    }
}


