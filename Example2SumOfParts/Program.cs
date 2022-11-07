// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

Console.WriteLine("Здравствуйте. Введите число");

int numberN = Convert.ToInt32(Console.ReadLine());

void SumAll(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр числа равна {sum}");
}

SumAll(numberN);