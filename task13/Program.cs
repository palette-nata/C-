// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number/100 == 0) 
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else {
int number2 = number <0 ? -number : number;
while (number2 > 999) number2 = number2/10;
Console.Write($"{number} -> {number2%10}");
}


