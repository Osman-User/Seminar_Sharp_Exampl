// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
Console.Clear();

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число 10 99, итог: {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// // Способ 1
// Console.WriteLine("Первый способ: ");
// if (firstDigit > secondDigit)
//     Console.WriteLine($"Наибольшая цифра цикла: {firstDigit}");
// else
//     Console.WriteLine($"Наибольшая цифра цикла: {secondDigit}");

// Способ 2
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

//                                      +            +
//                                    тогда        иначе
// Console.WriteLine("Второй способ: ");
// Console.WriteLine($"Наибольшая цифра цикла: {maxDigit}");

// Методы в функции всегда с большой буквы

int result = MaxDigit(number);

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}
Console.WriteLine($"Наибольшая цифра цикла: {result}");
