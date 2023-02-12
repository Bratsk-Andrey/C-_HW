// Задача №68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Recursion(int m, int n)
{
    if(m == 0)
        return n + 1;
    else if((m != 0) && (n == 0))
        return Recursion(m - 1, 1);
    else 
        return Recursion(m - 1, Recursion(m, n - 1));
}

int result = Recursion(m, n);
Console.Write(result);
