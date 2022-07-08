// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
namespace GeekBrains
{
    class Task_3
    {
        public static void Main(string[] args)
        {
            int a = new Random().Next(5, 11);
            int[] array = new int[a];

            ArrayRandom(array);
            PrintArray(array);
            Console.WriteLine();
            int max = Max(array);
            int min = Min(array);
            Diff(max, min);
        }  
        
        public static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static void Diff(int a, int b)
        {
            int diff = a - b;
            Console.Write($"Разница между максимальным и минимальным элементом: {diff}");
        }

        public static void ArrayRandom(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 16);
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}