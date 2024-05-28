
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int secondDigit = number / 10 % 10;
    int lastDigit = number % 10;
    int result = 1;

    for (int i = 0; i < lastDigit; i++)
    {
        result = result * secondDigit;
    }

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный ввод");
}

