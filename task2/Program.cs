// Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 100 && number <= 999)
// {
//     int secondDigit = number / 10 % 10;
//     int lastDigit = number % 10;
//     int result = 1;

//     for (int i = 0; i < lastDigit; i++)
//     {
//         result = result * secondDigit;
//     }

//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("Некорректный ввод");
// }

// Решения задач после второго семинара

// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Введеное число {number} одновременно кратно 7 и 23");
}
else
{
    Console.WriteLine($"Введеное число {number} одновременно не кратно 7 и 23");
}


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату x (x ≠ 0): ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y (y ≠ 0): ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой (1) четверти координатной плоскости");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй (2) четверти координатной плоскости");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей (3) четверти координатной плоскости");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой (4) четверти координатной плоскости");
}
else
{
    Console.WriteLine("Условия x ≠ 0 и y ≠ 0 не выполнены");
}

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите число от 10 до 99");
int numberOne = Convert.ToInt32(Console.ReadLine());

if (numberOne >= 10 && numberOne <= 99)
{
    int firstDigit = numberOne / 10;
    int secondDigit = numberOne % 10;
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
else
{
    Console.WriteLine("Введенное число не находиться в диапазоне от 10 до 99");
}

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}



// Из семинара № 3 

// int[] array = new int[5] {1, 3, 4, 19, 3};
// int[] array = { 1, 3, 4, 19, 3 };
// int num = 8;

// bool res = false;

// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] == num)
// {
// res = true;
// break;
// }
// }

// //string result = res ? "Да" : "Нет";
// Console.WriteLine(res ? "Да" : "Нет");



// int[] array = new int[10] { 1, -5, 6, 8, 2, -7, -2, 9, -5, 9 };

// for (int i = 0; i < array.Length; i++)
// {
// array[i] *= -1;
// }

// for (int i = 0; i < array.Length; i++)
// {
// Console.Write($"{array[i]} ");
// }

// int[] array = new int[5] {1, 3, 4, 19, 3};



int[] array = { 1, 3, 4, 19, 3 };
int num = 8;

bool res = false;

for (int i = 0; i < array.Length; i++)
{
if (array[i] == num)
{
res = true;
break;
}
}

//string result = res ? "Да" : "Нет";
Console.WriteLine(res ? "Да" : "Нет");




// int[] array2 = { 1, 3, 2, 4, 2, 3 };
// int[] array2 = { 2, 3, 1, 7, 5, 6, 3 };
// int[] resultArray = new int[array2.Length / 2];

// for (int i = 0; i < array2.Length / 2; i++)
// {
// resultArray[i] = array2[i] * array2[array2.Length - i - 1];
// }

// for (int i = 0; i < resultArray.Length; i++)
// {
// Console.Write(resultArray[i] + " ");
// }

