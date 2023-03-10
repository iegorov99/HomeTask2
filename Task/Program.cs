// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int num = numA;
int count = 0;
while (numA > 0)
{
    numA = numA / 10;
    count++;
}
if (count < 3) Console.WriteLine($"В числе {num} нет третьей цифры");
else
{
    while (count > 2)
    {
        if (count == 3)
        {
            int result = num % 10;
            Console.WriteLine($"Третья цифра {result}");
            break;
        }
        num = num / 10;
        count = count - 1;
    }
}
