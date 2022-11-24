﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] createArray()
{
    int[,,] arr = new int[2, 2, 2];
    Random rnd = new Random();
    for (int k = 0; k < 2; k++)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                arr[i,j,k] = rnd.Next(10, 99);
            }
        }
    }
    return arr;
}

void printArray(int[,,] arr)
{
    for (int k = 0; k < 2; k++)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
    }
}

int [,,] arr = createArray();
Console.WriteLine("Полученный массив по строкам с индексами элементов");
printArray(arr);
