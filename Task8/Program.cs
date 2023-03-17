// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int GetNumber(string welcome)
{
    System.Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
int num = GetNumber("Please enter number num: ");

int start = 2;
while (start <= num)
{
    Console.Write($"{start}");
    start += 2;
    if (start <= num)
    {
        Console.Write(", ");
    }
}
