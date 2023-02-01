// Задача №43
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2, k2 задаются пользователем.

Console.Clear();
double k1, k2, b1, b2;
Console.Write("Введите значение k1: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения ({x}; {y})");
