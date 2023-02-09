// Задача №58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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
Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
Console.Write("Введите количество строк первой матрицы: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int M2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int N2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[M, N];
int[,] array2 = new int[M2, N2];
int[,] array3 = new int[M, N2];

if(N != M2)
{
    Console.WriteLine("Такие матрицы умножать нельзя.");
    return;
}

Console.WriteLine("Первая матрица: ");
FillArray(array1);
PrintArray(array1);
Console.WriteLine("Вторая матрица: ");
FillArray(array2);
PrintArray(array2);

Console.WriteLine("Произведение двух матриц: ");

int[,] GetMultiplicationMatrix(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}

GetMultiplicationMatrix(array1, array2);
PrintArray(array3);