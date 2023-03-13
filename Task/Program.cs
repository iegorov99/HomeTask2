//задача 11 hard. Напишите программу, которая принимает от пользователя целое число любой разрядности и удаляет вторую цифру этого числа.

Console.Write("Введите целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int num = numA;
int count = 0;
while (numA > 0)
{
    numA = numA / 10;
    count++;
}
int count2 = count - 1;
if (count < 2)
{
    Console.WriteLine("Введено некорректное число");
}
else if (count == 2)
{
    int result = num / 10;
    Console.WriteLine($"Искомое число {result}");
}
else
{
    int first = num / Convert.ToInt32(Math.Pow(10, count - 1));
    int secondA = num % Convert.ToInt32(Math.Pow(10, count - 2));
    int position = 0;
    int second = secondA;
    while (secondA > 0)
    {
        secondA = secondA / 10;
        position++;
    }
    if (position < count - 2)
    {
        while (position < count - 2)
        {
            first = first * 10;
            position++;
        }
    }
    Console.WriteLine($"Искомое число {first}{second}");
}