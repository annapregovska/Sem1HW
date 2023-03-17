//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


int GetNumber(string welcome)
{
    System.Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = GetNumber("Enter first number num1: ");
int num2 = GetNumber("Enter second number num2: ");
int num3 = GetNumber("Enter third number num3: ");

int max = num1;
string maxName = "num1";
if (max < num2)
{
    max = num2;
    maxName = "num2";
}
if (max < num3) { max = num3; maxName = "num3"; }

System.Console.WriteLine($"Max number is {maxName} {max}");
