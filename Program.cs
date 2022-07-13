// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


internal class Program
{
    private static void Main(string[] args)
    {
        int[] CreateRandomArray(int size, int min, int max)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(min, max + 1);
            }
            return array;
        }

        void ShowArray(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        Console.Write("Введите количество элементов массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] myArray = CreateRandomArray(size , 100, 999);
        ShowArray(myArray);
        int N = 0;
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] % 2 == 0)
            {
                N++;
            }
            else
            {
                N = N + 0;
            }
        }
        Console.WriteLine($"Количество четных чисел: {N}");
    }
}