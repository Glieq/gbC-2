// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number > 999 || number < 100)
{
    Console.WriteLine("Вы ввели некорректное число");
}
else
{
    result = (number / 10) % 10;
    Console.WriteLine(result);
}
