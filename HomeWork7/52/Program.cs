// Задача №52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-15, 16);
        }
    }
}

void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}   ");
            }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.Write("Введите количество строк массива: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[M, N];
double avg = 0;

Console.WriteLine("Двумерный массив: ");
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(1); i++)
{
    avg = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        avg += array[j, i];
    }
    Console.WriteLine($"Среднее арифметическое {i + 1} столбца: {avg / M}");
}

