// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
if (number>1)
{
    int N = 2;
    while(N<=number)
    {
        if (N != 2) 
        {
            Console.Write(",");
        }
        Console.Write(N);
        
        N = N+2;
    }
}