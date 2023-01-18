// Задача №27 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void GetSummNumber(int N)
{
    Console.Write($"Сумма цифр в числе {N} = ");
    int sum = 0;
    while(N > 0)
    {
        sum += N % 10;
        N /= 10;
    }
    Console.Write(sum);
}

Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
GetSummNumber(num);