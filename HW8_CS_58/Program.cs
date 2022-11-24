// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] createArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
    return arr;
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrixMultiplication(int[,] A, int[,] B)
{
    int[,] result = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int k = 0; k < B.GetLength(1); k++)
        {
            int temp = 0;
            for (int j = 0; j < B.GetLength(0); j++)
            {
                temp += A[i, j] * B[j, k];
            }
            result[i, k] = temp;
        }
    }
    return result;
}

Console.WriteLine("Введите m1: ");
int m1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n1: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите m2: ");
int m2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n2: ");
int n2 = int.Parse(Console.ReadLine()!);
int[,] arr1 = createArray(m1, n1);
int[,] arr2 = createArray(m2, n2);
Console.WriteLine("Матрица A:");
printArray(arr1);
Console.WriteLine("Матрица B:");
printArray(arr2);
if (arr1.GetLength(1) == arr2.GetLength(0))
{
    int[,] arr3 = matrixMultiplication(arr1, arr2);
    Console.WriteLine("Произведение матриц A и B:");
    printArray(arr3);
}
else
{
    Console.WriteLine("Размерности матриц A и B не удовлетворяют условия перемножения матриц");
}