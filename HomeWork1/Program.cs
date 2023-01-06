class HM1
{
    static void Main()
    {

    
        // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        Console.Clear();
        Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());
        int max, min;
        if (a < b)
        {
            max = b;
            min = a;
        }
        else
        {
            max = a;
            min = b;
        }
        Console.WriteLine("Максимальное число: " + max + ", минимальное: " + min);
        Console.Write("Нажмите любую кнопку для продолжения");
        Console.ReadKey();

        // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        Console.Clear();
        Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
        Console.Write("Введите первое число: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int number3 = int.Parse(Console.ReadLine());
        int maxim = number1;

        if (number1 < number2)
        {
            maxim = number2;
        }
        if (number2 < number3)
        {
            maxim = number3;
        }
        if (number3 < number1)
        {
            maxim = number1;
        }
        Console.WriteLine("Максимальное число: " + maxim); 
        Console.Write("Нажмите любую кнопку для продолжения");
        Console.ReadKey();

        // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        Console.Clear();
        Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
        Console.Write("Введите число: ");
        int num1 = int.Parse(Console.ReadLine());
        if (num1 % 2 == 0)
            Console.WriteLine("Число " + num1 + " чётное");
        else 
            Console.WriteLine("Число " + num1 + " нечётное");
        Console.Write("Нажмите любую кнопку для продолжения");
        Console.ReadKey();

        // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
        Console.Clear();
        Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
        Console.Write("Введите число: ");
        int num4 = int.Parse(Console.ReadLine());
        int count = 1;
        while (count <= num4)
        {
            if (count % 2 == 0)
            {
                Console.Write(" " + count);
                count++;
            }
            else
            {
                count++;
            }
        } 
    }
}