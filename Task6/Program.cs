// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int GetNumber(string welcome)
{
    System.Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetNumber("Please enter a number num: ");

if (num % 2 == 0)
    Console.WriteLine($"Number num {num} is even");
else
    Console.WriteLine($"Number num {num} NOT even");