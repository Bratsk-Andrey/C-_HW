class HM3_23
{
    static void Main()
    {
        //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        Console.Clear();
        Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
        Console.Write("Введите число: ");
        int num1 = int.Parse(Console.ReadLine());
        int cub1 = 0;
        int index1 = 1;

        while(index1 <= num1)
        {
            cub1 = index1 * index1 * index1;
            Console.Write(" " + cub1);
            index1++;
        }
    }
}