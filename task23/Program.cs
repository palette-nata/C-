//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int counte = 1;
while(counte < number)
{
    Console.WriteLine($"Число {counte}, возведенное в куб, равно {counte*counte*counte}");
    counte++;
}