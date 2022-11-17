// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
//N = 5 -> "4, 2"
//N = 8 -> "8, 6, 4, 2,"

Run();

void Run() 
{
    Console.WriteLine("Введите целое положительное число");
    int number = int.Parse(Console.ReadLine());
    EvenNumbers(number);
}

void EvenNumbers(int number) 
{
    PrintNumber(number%2 == 0? number : --number);
}

void PrintNumber(int number)
{
    if(number <= 0) return;

    Console.Write($"{number} ");
    PrintNumber(number-2);
}
