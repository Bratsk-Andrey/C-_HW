// Задача №41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите количество цифр: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Полученный массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine();
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    count++;
}
Console.WriteLine($"Количество элементов больше 0: {count}");