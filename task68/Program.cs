// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Run();
    void Run()
{
    Console.WriteLine("Введите число m");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число n");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"Функция Аккермана чисел ({m}, {n}) равна {Akkerman((uint)m, (uint)n)}");
}

uint Akkerman(uint m, uint n)
{
    if (m == 0)  return n+1; 
    if (m > 0 && n ==0)  return Akkerman(m - 1, 1); 
    return Akkerman(m-1,Akkerman(m,n-1));
}
