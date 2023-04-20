/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] CreateArray(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
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

void TheProductOfTwoMatrices(int[,] matrix1, int[,] matrix2, int[,] product)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(0); j++)
        {
            int result = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result += matrix1[i, k] * matrix2[k, j];
            }
            product[i, j] = result;
        }
    }
}

int m = CreateSizeArray("number of rows: ");
int n = CreateSizeArray("number of columns: ");

int[,] array1 = CreateArray(m, n);
Console.WriteLine("The first matrix:"); 
PrintArray(array1);
Console.WriteLine();

int[,] array2 = CreateArray(m, n);
Console.WriteLine("The second matrix:"); 
PrintArray(array2);
Console.WriteLine();

int[,] product = new int[m, n];
TheProductOfTwoMatrices(array1, array2, product);
Console.WriteLine("The product of two matrices:");
PrintArray(product);