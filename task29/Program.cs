// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
//6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]
int[] array01 = new int[8];
void NewArray (int[] array01)
{
int length = array01.Length;
Console.Write("[");
for (int i = 0; i < length-1; i++)
{
    array01[i] = new Random().Next(0,1000);
    Console.Write($"{array01[i]}, ");
}
array01[length-1] = new Random().Next(0,1000);
Console.Write(array01[length-1]);
Console.Write("]");
}
NewArray(array01);