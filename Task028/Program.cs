// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int result = CompositionNumbers(num);

Console.WriteLine($"Факториал {num} равен: {result}");

int CompositionNumbers(int num)
{
    int factorial = 1;
    while (num != 0)
    {
        checked
        {
            factorial *= num;
            num--;
        }
    }
    return factorial;
}
