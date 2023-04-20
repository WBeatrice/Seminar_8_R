/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] CreateArray(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    int a = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0)
            {
                a = a + 1;
                array[i, j] = a;
            }
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

void SpiralFillingArray(int[,] array) //Спиральное заполнение массива 
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;

        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

int m = CreateSizeArray("size of the array: ");
int[,] array = CreateArray(m, m);
Console.WriteLine("first array: ");
PrintArray(array);
Console.WriteLine();

SpiralFillingArray(array);
Console.WriteLine("second array:");
PrintArray(array);