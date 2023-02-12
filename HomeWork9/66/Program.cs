// Задача №66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int Recursion(int M, int N)
{
    if(M <= N)
    {
        sum += M;
        Recursion(M + 1, N);
    }
    return sum;
}

Recursion(M, N);
Console.Write($"Сумма чисел: {sum}");
