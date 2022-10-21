// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
    res[i] = new Random().Next(minValue, maxValue + 1);
    Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array = GetArray(4, -100, 100);
Console.WriteLine();
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if(i%2 != 0)
    sum = sum + array[i];
}

Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях, равна {sum}");

