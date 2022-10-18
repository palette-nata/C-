// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");  
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумму цифр числа {num1} равна {SumNums(num1)}");

int SumNums(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number%10;
        number /= 10;
    }
    return sum;
}

