/*Задача 60. ...Сформируйте трёхмерный массив из случайных чисел. 
 * Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] CreateArray(int length1, int length2, int length3)
{
    int[,,] array = new int[length1, length2, length3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(-100, 100);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})\t");
            }
        }
        Console.WriteLine();
    }
}

int CreateSizeArray(string number)
{
    Console.Write($"Enter the {number} ");
    int n = int.Parse(Console.ReadLine());
    return n;
}



int i = CreateSizeArray("first size: ");
int j = CreateSizeArray("second size: ");
int k = CreateSizeArray("third size: ");
int[,,] array = CreateArray(i, j, k);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();