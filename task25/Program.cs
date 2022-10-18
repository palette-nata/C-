// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число A: ");  
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");  
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {num1} в степени {num2} равно {ToDegree(num1, num2)}");

int ToDegree(int number1, int number2)
{
    int resulte = 1;
    for (int i = 1; i <= number2; i++)
    {
        resulte = resulte*number1;
    }
    return resulte;
}
