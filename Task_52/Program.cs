/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3. */

bool run = true;
while (run)
{
    Console.Clear();

    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество колонок массива: ");
    int cols = int.Parse(Console.ReadLine());

    int[,] arr = GetArray(rows, cols);
    PrintArray(arr);
    PrintAverage(arr);

    Console.WriteLine();
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

int[,] GetArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random newRnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = newRnd.Next(0, 10);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double FindAverageInRow(int[,] array, int row)
{
    int sum = 0;
    int amount = array.GetLength(1);

    for (int i = 0; i < amount; i++)
        {
            sum += array[row, i];
        }
    double average = Convert.ToDouble(sum) / Convert.ToDouble(amount);
    return average;
}

void PrintAverage(int[,] arr)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(Math.Round(FindAverageInRow(arr, i), 1) + "; ");
    }
}