﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите трехзначное целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}

if (number >= 100 && number <= 999)
{
    int result = number % 10;
    Console.WriteLine($"Последняя цифра числа: {result}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}

int result2 = number / 100; // Первая цифра трехзначного числа
int result3 = number / 10 % 10; // Вторая цифра трехзначного числа


/* Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Число не натуральное");
}
else
{
    // for(int i = -number; i <= number; i++){
    //     Console.Write($"{i} ");
    // }

    int count = -number;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count++;
    }
} */
