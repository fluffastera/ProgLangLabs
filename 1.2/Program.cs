namespace lab01_2
{
    public class Program()
    {
        public static void Main()
        {                
            int[,] matrix = GetRandomMatrix(8, 8, 200);
            PrintMatrix(matrix);
            List<int> ks = FindMatchingRowsColumns(matrix);
            Console.WriteLine("Подходящие k: " + string.Join(" ", ks));
            List<int> sums = FindSumsOfNegativeRows(matrix);
            Console.WriteLine("Суммы строк с отрицательными элементами " + string.Join(" ", sums));
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");    
                }
                Console.WriteLine();
            }
        }

        public static int[,] GetRandomMatrix(int n, int m, int randomSeed = 0)
        {
            Random random = new Random(randomSeed);
            int[,] matrix = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(-1, 1);
                }
            }
            return matrix;
        }

        public static List<int> FindMatchingRowsColumns(int[,] matrix)
        {
            List<int> ks = new List<int>();
            if(matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException("Матрица не квадратная!");
            }
            int n = matrix.GetLength(0);
            for(int k = 0; k < n; k++)
            {
                bool hadNonMatching = false;
                for(int i = 0; i<n; i++)
                {
                    if (matrix[k, i] != matrix[i, k])
                    {
                        hadNonMatching = true;
                    }
                }
                if(hadNonMatching)
                {
                    continue;
                }
                ks.Add(k);
            }
            return ks;
        }

        public static List<int> FindSumsOfNegativeRows(int[,] matrix)
        {
            List<int> sums = new List<int>();
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                bool hasNegative = false;
                int curSum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                    }
                    curSum += matrix[i, j];
                }
                if(hasNegative)
                {
                    sums.Add(curSum);
                }
            }
            return sums;
        }
    }
}