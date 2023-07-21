// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int result = number * number;
System.Console.WriteLine($"Решение: {number}*{number}");
System.Console.WriteLine($"Ответ: {result}");