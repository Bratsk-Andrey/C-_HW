// Задача №50 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

int[,] array = new int[5, 5];

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool rezult = false;

Console.WriteLine("Двумерный массив: ");
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        if (num == array[i, j]) rezult = true;
}
if (rezult == true)
    Console.WriteLine($"Число {num} присутствует в массиве.");
else
    Console.WriteLine($"Числа {num}, нет в массиве.");