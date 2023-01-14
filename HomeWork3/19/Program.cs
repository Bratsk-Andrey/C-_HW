class HM3_19
{
    static void Main()
    {
        //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        Console.Clear();
        Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
        Console.Write("Введите пятизначное число: ");
        int num4 = int.Parse(Console.ReadLine());
        int first = num4 / 10000;
        int second = (num4 / 1000) - first * 10;
        int third = (num4 / 100) - first * 100 - second * 10;
        int fourth = (num4 / 10) - first * 1000 - second * 100 - third * 10;
        int fifth = num4 % 10;

        if((fifth == first) && (fourth == second))
        Console.WriteLine("Число " + num4 + " является палиндромом");
        else
        Console.WriteLine("Число " + num4 + " не является палиндромом");
    }
}