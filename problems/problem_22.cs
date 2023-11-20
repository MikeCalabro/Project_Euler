// What is the total of all the name scores in the file?

namespace ProjectEuler
{
    class Problem_22
    {
        public static long TotalNameScore(string problem = "problem_22")
        {
            string filePath = $"problem_files/{problem}_names.txt";
            string namesRaw = File.ReadAllText(filePath);
            string namesClean  = namesRaw.Replace("\"","");
            string[] namesArr = namesClean.Split(',');
            Array.Sort(namesArr);
            int nameSum, nameScore, totalScore = 0;
            
            for(int i = 0; i < namesArr.Length; i++)
            {
                nameSum = 0;
                nameScore = 0;

                for(int j = 0; j < namesArr[i].Length; j++)
                {
                    nameSum += ((int)namesArr[i][j] - 64);
                }
                
                nameScore += (nameSum * (i+1));
                totalScore += nameScore;
            }

            return totalScore;
        }
    }
}