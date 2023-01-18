// Задача №29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
int size = 8;
int[] array = new int[size];
Random rnd = new Random();
Console.Write("Массив из 8 элементов: ");

for(int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-100, 100);
    Console.Write(array[i] + " ");
}