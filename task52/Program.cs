﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillMatrixWhithRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} " + "\t");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите колчество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите колчество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);

void FindCount(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            count += matrix[i,j];
        }
        Console.WriteLine($"Среднее арифметическое элементов в столбце{j+1} равно {count/matrix.GetLength(0)}");
    }
}

FindCount(matrix);
