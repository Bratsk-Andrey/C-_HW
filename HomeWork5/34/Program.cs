// Задача №34
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве. 
class HM5_34
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
        int size = 6, count = 0;
        int[] array = new int[size];
        Random rnd = new Random();
        Console.Write("Массив заполеннный случайными положительными трехзначными числами: ");
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100, 1000);
            Console.Write(array[i] + " ");
        }
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            count++;
        }
        Console.WriteLine();
        Console.Write($"Количество чётных чисел в массиве: {count}");
    }
}