// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.WriteLine("Здравствуйте. Поочерёдно введите число и степень");
double numA = Convert.ToDouble(Console.ReadLine());
double numB = Convert.ToDouble(Console.ReadLine());
double result = Math.Pow(numA , numB);
Console.WriteLine($"Число {numA} в степени {numB} = {result}");