//Задача 2:Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее. 
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Please enter first number (num1): ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter second number (num2): ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"First number {num1}, second number {num2}");
if (num1 == num2)
{
    Console.WriteLine($"Numbers are egual");
}
if (num1 > num2)
{
    Console.WriteLine($"First number {num1} greater as the second number {num2}");
}
else
{
    Console.WriteLine($"Second number {num2} is greater as the first number {num1}");
}

