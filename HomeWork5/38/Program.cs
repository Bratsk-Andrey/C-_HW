// Задача №38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
class HM5_38
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        Console.Write("Задайте количество элементов в массиве: ");
        int size = int.Parse(Console.ReadLine());
        Console.Write("Массив вещественных чисел: ");
        double S = 0; 
        double[] array = new double[size];
        Random rnd = new Random();
        void GetArray(double[] A)
        {
            for(int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.NextDouble() * 100;
                Console.Write($"| {A[i]:f1} |");
            }
        }
        GetArray(array);
        double min = array[0], max = array[0];
        for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < min)
                min = array[i];
                else if (array[i] > max)
                max = array[i];
            }
        Console.WriteLine();
        Console.Write($"Разница между минимальным и максимальным значениями = {S = max - min:f1}");
    }
}