// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
namespace GeekBrains
{
    class Task_2
    {
        public static void Main(string[] args)
        {
            int a = new Random().Next(5, 11);
            int[] array = new int[a];

            ArrayRandom(array);
            PrintArray(array);
            Console.WriteLine();
            Sum(array);
        }  
        
        public static void Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + arr[i];
                }
            }
            Console.Write($"Сумма элементов нечетных индексов: {sum}");
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








