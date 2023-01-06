class HW2
{
    static void Main()
    {
        // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        Console.Clear();
        Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
        Console.Write("Введите трёхзначное число: ");
        int Numb1 = int.Parse(Console.ReadLine());
        int res = 0;

        if (Numb1 < 0) Numb1 = Numb1 * (-1);
        while (Numb1 > 100)
        {
            Numb1 = Numb1 / 10;
            res = Numb1 % 10;
        }
        Console.WriteLine("Вторая цифра числа: "+ res); 

        Console.Write("Нажмите любую кнопку для продолжения");
        Console.ReadKey(); 

        // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

        Console.Clear();
        Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        Console.Write("Введите число: ");
        int Numb2 = int.Parse(Console.ReadLine());
        int digitCount = (int)Math.Log10(Numb2) + 1;
        int thirdNumber = 0; 
        int sk = 0; 
        int step = 0;

        if(digitCount <= 2)
        {
            Console.WriteLine("В этом числе нет третьей цифры.");
        }
        else if(digitCount == 3)
        {
            thirdNumber = Numb2 % 10;
            Console.WriteLine("Третья цифра числа: " + thirdNumber);
        }
        else
        {
            step = (int)Math.Pow(10, digitCount - 2);
                sk = Numb2 % step;
            thirdNumber = sk / (int)Math.Pow(10, digitCount - 3);
            Console.WriteLine("Третья цифра числа: " + thirdNumber);
        } 
        Console.Write("Нажмите любую кнопку для продолжения");
        Console.ReadKey(); 

        // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

        Console.Clear();
        Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        Console.Write("Введите число дня недели: ");
        int Numb3 = int.Parse(Console.ReadLine());

        switch (Numb3)
        {
            case 1:
                Console.WriteLine("Понедельник не является выходным днем");
                break;
            case 2:
                Console.WriteLine("Вторник не является выходным днем");
                break;
            case 3:
                Console.WriteLine("Среда не является выходным днем");
                break;
            case 4:
                Console.WriteLine("Четверг не является выходным днем");
                break;
            case 5:
                Console.WriteLine("Пятница не является выходным днем");
                break;
            case 6:
                Console.WriteLine("Суббота является выходным днем");
                break;
            case 7:
                Console.WriteLine("Воскресенье является выходным днем");
                break;
            default:
                Console.WriteLine("Вы ввели некорректное число");
                break;
        }
    }
}








