/*Задача 56: Задайте прямоугольный двумерный массив. 
 * Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

int SumElementsArray(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Sum of elements in a row {i + 1}: {sum}"); 
    return sum;
}

void MinSumOfElements(int[,] array)
{
    int min = 0;
    int sum = SumElementsArray(array, 0);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = SumElementsArray(array, i);
        if (sum > temp)
        {
            sum = temp;
            min = i;
        }
    }
    Console.WriteLine($"The number of the row with the smallest sum of elements: {min + 1}"); 
}

int m = CreateSizeArray("number of rows: ");
int n = CreateSizeArray("number of columns: ");
int[,] array = CreateArray(m, n);
PrintArray(array);
Console.WriteLine();

MinSumOfElements(array);