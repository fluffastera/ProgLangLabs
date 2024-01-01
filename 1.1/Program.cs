namespace lab01_1 {
    public class Program()
    {
        public static void Main()
        {
            int[] array = MakeRandomArray(10, 42);
            PrintArray(array);
            int maxIndex = FindMaxIndex(array);
            Console.WriteLine("Индекс максимального элемента " + maxIndex);
            int firstZero = FindZero(array);
            if (firstZero == -1)
            {
                Console.WriteLine("Нет нуля.");
                return;
            }
            int secondZero = FindZero(array, firstZero + 1);
            if (secondZero == -1)
            {
                Console.WriteLine("Нет второго нуля.");
                return;
            }
            int mulBetweenZeros = FindProduct(array, firstZero + 1, secondZero);
            Console.WriteLine("Произведение между двумя нулями: " +  mulBetweenZeros);
            int[] movedArray = MoveOddToTheFront(array);
            Console.WriteLine("Преобразованный массив:");
            PrintArray(movedArray);
        }

        public static int[] MakeRandomArray(int size, int seed = 0)
        {
            Random r = new Random(seed);
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-10, 10);
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }


        public static int FindMaxIndex(int[] array)
        {
            int maxIndex = -1;
            for (int i = 0; i < array.Length; ++i)
            {
                if (maxIndex == -1 || array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int FindZero(int[] array, int start = 0)
        {
            for (int i = start; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FindProduct(int[] array, int start, int end)
        {
            if (start == end)
            {
                return 0;
            }
            int mul = 1;
            for(int i = start; i < end; ++i) { 
                mul *= array[i];
            }
            return mul;
        }

        public static int[] MoveOddToTheFront(int[] array)
        {
            int[] newArray = new int[array.Length];
            int j = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                newArray[j] = array[i];
                j++;
            }
            for (int i = 1; i < array.Length; i += 2)
            {
                newArray[j] = array[i];
                j++;
            }
            return newArray;
        }
    }
}