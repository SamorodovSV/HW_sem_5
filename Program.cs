// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int[] CreateRandomArray(int size, int min, int max)
//         {
//             int[] array = new int[size];
//             for (int i = 0; i < size; i++)
//             {
//                 array[i] = new Random().Next(min, max + 1);
//             }
//             return array;
//         }

//         void ShowArray(int[] array)
//         {

//             for (int i = 0; i < array.Length; i++)
//             {
//                 Console.Write(array[i] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.Clear();
//         Console.Write("Введите количество элементов массива: ");
//         int size = Convert.ToInt32(Console.ReadLine());
//         int[] myArray = CreateRandomArray(size , 100, 999);
//         ShowArray(myArray);
//         int N = 0;
//         for (int i = 0; i < myArray.Length; i++)
//         {
//             if (myArray[i] % 2 == 0)
//             {
//                 N++;
//             }
//             else
//             {
//                 N = N + 0;
//             }
//         }
//         Console.WriteLine($"Количество четных чисел: {N}");
//     }
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int[] CreateRandomArray(int size, int min, int max)
//         {
//             int[] array = new int[size];
//             for (int i = 0; i < size; i++)
//             {
//                 array[i] = new Random().Next(min, max + 1);
//             }
//             return array;
//         }

//         void ShowArray(int[] array)
//         {

//             for (int i = 0; i < array.Length; i++)
//             {
//                 Console.Write(array[i] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.Clear();
//         Console.Write("Введите количество элементов массива: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//          Console.Write("Введите минимальное число: ");
//         int start = Convert.ToInt32(Console.ReadLine());
//          Console.Write("Введите максимальное число: ");
//         int end = Convert.ToInt32(Console.ReadLine());
//         int[] myArray = CreateRandomArray(num , start, end);
//         ShowArray(myArray);
//         int sum = 0;
//         for (int i = 0; i < myArray.Length; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 sum = sum + 0;
//             }
//             else
//             {
//                 sum = sum + myArray[i];
//             }
//         }
//         Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
//     }
// }



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int[] CreateRandomArray(int size, int min, int max)
//         {
//             int[] array = new int[size];
//             for (int i = 0; i < size; i++)
//             {
//                 array[i] = new Random().Next(min, max + 1);
//             }
//             return array;
//         }

//         void ShowArray(int[] array)
//         {

//             for (int i = 0; i < array.Length; i++)
//             {
//                 Console.Write(array[i] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.Clear();
//         Console.Write("Введите количество элементов массива: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//          Console.Write("Введите минимальное число: ");
//         int start = Convert.ToInt32(Console.ReadLine());
//          Console.Write("Введите максимальное число: ");
//         int end = Convert.ToInt32(Console.ReadLine());
//         int[] myArray = CreateRandomArray(num , start, end);
//         ShowArray(myArray);
//         int min1 = myArray[0];
//         int max1 = myArray[0];
//         int result = 0;

//         for (int i = 0; i < myArray.Length; i++)
//         {
//             if (myArray[i] > max1)
//             {
//                 max1 = myArray[i];
//             }
//             else if (myArray[i] < min1)
//             {
//                 min1 = myArray[i];
//             }

//         }
//         result = max1 - min1;
//         Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");
//     }
// }
