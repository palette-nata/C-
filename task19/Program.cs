// Задача 19
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int len =0;
int num1 = num;
while(num1>0) 
{
    num1=num1/10;
    len++;
}

if (len == 5)
{
    if (GetDigitByPosition(num,1) == GetDigitByPosition(num,5) && GetDigitByPosition(num,2) == GetDigitByPosition(num,4))
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {num} - не является пятизначным");
}

int GetDigitByPosition(int number, int position)
{
    while (number > Math.Pow(10,position)-1) number = number/10;
    return number%10;
}