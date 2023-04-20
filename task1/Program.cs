/*Задайте двумерный массив. 
 Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int[,] CreateArray(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
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

void NumbersInDescendingOrder(int[,] array)
{
    int temp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(1) - 1; s++)
            {
                if (array[i, s] > array[i, s + 1])
                {
                    temp = array[i, s];
                    array[i, s] = array[i, s + 1];
                    array[i, s + 1] = temp;
                }
            }
        }
    }

}

int m = CreateSizeArray("number of rows: ");
int n = CreateSizeArray("number of columns: ");
int[,] array = CreateArray(m, n);
PrintArray(array);
Console.WriteLine();

NumbersInDescendingOrder(array);
PrintArray(array);