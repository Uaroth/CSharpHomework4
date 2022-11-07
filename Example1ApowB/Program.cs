// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.WriteLine("Здравствуйте. Поочерёдно введите число и степень");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
void PowRes(int num1 , int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    } 
    Console.WriteLine($"Число {num1} в степени {num2} = {result}");
}
PowRes(numA, numB);
