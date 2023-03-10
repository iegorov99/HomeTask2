// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
try
{
    Console.Write("Введите трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int num2 = num;
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    if (count != 3) Console.WriteLine("Введено некоректное число");
    else
    {
        int result = num2 / 10;
        result = result % 10;
        Console.WriteLine($"Вторая цифра введённого числа {result}");
    }
}
catch
{
    Console.WriteLine("Введено некорректное число");
}