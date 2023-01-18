// Задача №25
// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
int function1(int num1, int num2)
{
    int degree = 1;
    for(int i = 1; i <= num2; i++)
    {
        degree *= num1;
    }
    return degree;
}

Console.Clear();
Console.WriteLine("Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.");
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"{A} в степени {B} = {function1(A, B)}");
