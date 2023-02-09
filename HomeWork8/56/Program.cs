// Задача №56
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.Write("Введите количество строк массива: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int rowMin = 1, min = 0;
int[,] array = new int[M, N];

Console.WriteLine("Прямоугольный массив: ");
FillArray(array);
PrintArray(array);
FindMinSunRow(array);
Console.Write($"Строка с наименьшей суммой элементов: {rowMin}");

void FindMinSunRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if (sum < min)
        {
        min = sum;
        rowMin = i + 1;
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки: {sum}");
    }
}