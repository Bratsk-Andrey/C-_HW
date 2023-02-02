// Задача №36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 
class HM5_36
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
        int size = 8, sum = 0;
        int[] array = new int[size];
        Random rnd = new Random();
        Console.Write("Массив заполеннный случайными числами: ");
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-100, 100);
            Console.Write(array[i] + " ");
        }
        for(int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1)
            sum += array[i];
        }
        Console.WriteLine();
        Console.Write($"Сумма нечётных элементов массива: {sum}");
    }
}