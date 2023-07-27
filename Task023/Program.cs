// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

// Решение 1 по проще
// System.Console.WriteLine($"Введите число N:");
// int number = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Таблици квадратов чисел от 1 до {n}:");
// for (int i = 1; i <= number; i++)
// {
//     System.Console.Write($"{Math.Pow(i, 2)} ");
// }


//  Решение 2 по проще
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}
SquareTable(number);

void SquareTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int square = i * i;
        Console.WriteLine($"{i}     {square}");
    }
}
