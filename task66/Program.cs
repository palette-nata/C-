// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Run();

void Run() 
{
    Console.WriteLine("Введите первое число");
    int number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int number2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{Sum(number2, number1)}");

}

int Sum(int number1, int number2)
{
    if (number1 == number2) return number2;

    return number1 + Sum(--number1, number2);
}