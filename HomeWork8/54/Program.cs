// Задача №54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] SortRow(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1); k++)
            {
                if(array[i,j] > array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}

Console.Clear();
Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.Write("Введите количество строк массива: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[M, N];

Console.WriteLine("Двумерный массив: ");
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированный двумерный массив: ");
SortRow(array);
PrintArray(array);


