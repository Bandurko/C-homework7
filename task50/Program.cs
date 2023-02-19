// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1, 7] -> такого числа в массиве нет

using System;
using static System.Console;

Clear();

int rows = new Random().Next(4, 11);
int columns = new Random().Next(4, 11);

Write("Введите номер строки искомого элемента массива: ");
int y = int.Parse(ReadLine());

Write("Введите номер столбца искомого элемента массива: ");
int x = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

if (FindElem(array, y, x))
{
    Console.WriteLine($"Элемент [{y}, {x}] в данном массиве равен {array[y,x]}");
}
else{
    Console.WriteLine($"Элемента с индексом [{y}, {x}] в данном массиве нет");
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}


bool FindElem(int[,] array, int y, int x)
{
    int j = array.GetLength(0);
    int i = array.GetLength(1);
    return (0 <= y && y <= j && 0 <= x && x <= i);
}
