// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

Console.WriteLine("Ваш случайный массив из 8 элементов готов");

int[] numbers = new int[8];

EightRandoms(numbers);

void EightRandoms(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next();
        Console.Write($"{numbers[i]} . ");
    }  
}


