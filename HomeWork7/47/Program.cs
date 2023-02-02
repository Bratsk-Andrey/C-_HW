// Задача №47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillDoubleArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            // matr[i, j] = new Random().Next(-10, 10);
            // A[i] = rnd.NextDouble() * 100;
            matr[i, j] = new Random().NextDouble() * 100;
        }
    }
}

void PrintArray(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]:f2}   ");
            }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.");
Console.Write("Введите количество строк массива: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[M, N];

Console.WriteLine($"Двумерный массив размером {M}x{N}, заполненный случайными вещественными числами: ");
FillDoubleArray(array);
PrintArray(array);

