
/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] array = new int[2, 2, 2];

Run();

void Run()
{
    FillArray();
    PrintArray();
}

void FillArray()
{
    Random rnd = new Random();

    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);
    int zSize = array.GetLength(2);

    for (int x = 0; x < xSize; x++)
    {
        for (int y = 0; y < ySize; y++)
        {
            for (int z = 0; z < zSize; z++)
            {
                int num;
                num = rnd.Next(10,99);
                while (ExistingNumber(num))
                { 
                    num = rnd.Next(10, 99); 
                }

                array[x, y, z] = num;
            }
        }
    }
}

bool ExistingNumber(int number)
{
    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);
    int zSize = array.GetLength(2);

    for (int x=0; x<xSize; x++)
    {
        for(int y=0; y<ySize; y++)
        {
            for (int z=0; z<zSize; z++)
            {
                if (number == array[x,y,z]) 
                    return true;
            }
        }

    }

    return false;
}

void PrintArray()
{
    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);
    int zSize = array.GetLength(2);

    for (int x = 0; x < xSize; x++)
    {
        for (int y = 0; y < ySize; y++)
        {
            for (int z = 0; z < zSize; z++)
            {
                Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
                
            }
            Console.WriteLine();
        }
    }
}
