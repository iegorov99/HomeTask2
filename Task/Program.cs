// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
try
{
Console.Write("Введите номер недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7 && num < 1) Console.WriteLine("Такого дня недели не существует");
switch (num)
{
    case 1:
        Console.WriteLine("Рабочий день");
        break;
    case 2:
        Console.WriteLine("Рабочий день");
        break;
    case 3:
        Console.WriteLine("Рабочий день");
        break;
    case 4:
        Console.WriteLine("Рабочий день");
        break;
    case 5:
        Console.WriteLine("Рабочий день");
        break;
    case 6:
        Console.WriteLine("Выходной день");
        break;
    case 7:
        Console.WriteLine("Выходной день");
        break;
}
}
catch 
{
Console.WriteLine("Введён некорректный символ");
}