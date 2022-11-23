// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] createArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(201) - 100;
        }
    }
    return arr;
}

void printArray(int[,] arr, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] sortArray(int[,] arr, int m, int n)
{
    int[,] result = arr;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int q = 0; q < arr.GetLength(1) - 1; q++)
        {
            if (arr[i, q] < arr[i, q + 1])
            {
                int temp = 0;
                temp = arr[i, q];
                arr[i, q] = arr[i, q + 1];
                arr[i, q + 1] = temp;
            }
        }
    }
}
    return arr;
}


Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] arr = createArray(m, n);
printArray(arr, m, n);
int[,] sortedArr = sortArray(arr, m, n);
Console.WriteLine("Отсортированный массив:");
printArray(sortedArr, m, n);

