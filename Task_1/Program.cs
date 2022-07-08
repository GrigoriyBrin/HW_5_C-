// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
namespace GeekBrains
{
    class Task_1
    {
        public static void Main(string[] args)
        {
            int a = new Random().Next(5, 11);
            int[] array = new int[a];

            ArrayRandom(array);
            PrintArray(array);
            Console.WriteLine();
            Valid(array);
        }  
        
        public static void Valid(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.Write($"Количество четных чисел в массиве: {count}");
        }
        
        public static void ArrayRandom(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(100, 1000);
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







