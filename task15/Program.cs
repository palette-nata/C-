// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите номер дня недели: ");
int numberWeek = int.Parse(Console.ReadLine());
if(numberWeek == 6 || numberWeek == 7)
{
    Console.WriteLine("ВЫХОДНОЙ");
}
else if(numberWeek>0 && numberWeek<6)
{
    Console.WriteLine("РАБОЧИЙ ДЕНЬ");
}
else 
{
     Console.WriteLine("не верный номер");
}

