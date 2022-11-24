// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] sumMinLine(int[,] arr, int m, int n)
{
    int sum = 0;
    int minimalsum = Int32.MaxValue;
    int lineIndex = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < minimalsum)
        {
            minimalsum = sum;
            lineIndex = i;
        }
        sum = 0;
    }
    int[] result = {minimalsum, lineIndex};
    return result;
}
Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] arr = createArray(m, n);
printArray(arr, m, n);
int[] searchLine = sumMinLine(arr, m, n);
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (searchLine [1]) + ". Сумма элементов строки " + (searchLine [1]) + " равна " + (searchLine [0]));




