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

Write("Введите номер строки искомого элемента массива: ");
int y=int.Parse(ReadLine());

Write("Введите номер строки искомого элемента массива: ");
int x=int.Parse(ReadLine());

int rows = new Random().Next(0, 11);
int columns = new Random().Next(0, 11);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

// int findel = GetFindElem((array));
//  WriteLine($"Элемент [{String.Join(", ", y, x)}] в данном ассиве равен {findel}");

//  WriteLine($"Элемента [{String.Join(", ", y, x)}] в данном ассиве нет");


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


void PrintFindElem(int[,] inArray, int y, int x)
{    
    /*for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == y && j == x)
            Write($"Элемент [{y}, {x}] в данном ассиве равен {array[i,j]}");
        }
            WriteLine($"Элемента [{y}, {x}] в данном ассиве нет");
        
    }
     int findelem = null;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[y, x])
            {
                findelem = array[i, j];
                break;
            }
            
        }
    }
    return findelem; */
}
