// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет


Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("a = " + firstNumber + ", b = " + secondNumber + " => да");
}
else
{
    Console.WriteLine($"a = {firstNumber}, b = {secondNumber} => нет");
}
System.Console.WriteLine();



// часть кода для Задачи 1 
int firstNumber1 = 1;
int secondNumber1 = 1;

if (firstNumber1 > secondNumber1)
{
    Console.WriteLine("первое число больше");
}
else if (firstNumber1 < secondNumber1)
{
    Console.WriteLine("второе число больше");
}
else
{
    Console.WriteLine("числа равны");
}

// Задача 2
int one = 1;
int two = 3;
int three = 8;
int max = one;

if (one > max)
{
    max = one;
}
if (two > max)
{
    max = two;
}
if (three > max)
{
    max = three;
}
Console.WriteLine(max);

// Задача 3
