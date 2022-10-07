// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string numberStr = number.ToString(); 
if(number/100 == 0) 
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else if (number>=0) 
{ 
       Console.Write($"{number} -> {numberStr[2]}");
} else 
{
    Console.Write($"{number} -> {numberStr[3]}");
}


