/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

using System;
using static System.Console;

int[,] myArray1 = CreateNewArray();
ShowArray(myArray1);
WriteLine();
int[,] myArray2 = CreateNewArray2();
ShowArray(myArray2);
WriteLine();
WriteLine("Произведение двух матриц: ");
MatrixMultiplication(myArray1, myArray2);

int[,] CreateNewArray()
{
    WriteLine("Введите размер матрицы А: ");
    int size = Convert.ToInt32(ReadLine());
    int[,] array = new int[size, size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 4);
        }
    }
    return array;
}
int[,] CreateNewArray2()
{
    WriteLine("Введите размер матрицы В: ");
    int size = Convert.ToInt32(ReadLine());
    int[,] array = new int[size, size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 4);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j]);
            Write(" ");
        }
        WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] arrA, int[,] arrB)
{
    int[,] res = new int[arrA.GetLength(0), arrB.GetLength(1)];
    if (arrA.GetLength(1) == arrB.GetLength(0))
    {
        for (int i = 0; i < arrA.GetLength(0); i++)
        {
            for (int j = 0; j < arrB.GetLength(1); j++)
            {
                for (int k = 0; k < arrB.GetLength(0); k++)
                {
                    res[i, j] += arrA[i, k] * arrB[k, j];
                }
                Write(res[i, j] + " ");
            }
            WriteLine();
        }
    }
    else
        WriteLine("Количество столбцов матрицы A должно быть равно количеству строк матрицы B");
    return res;
}
