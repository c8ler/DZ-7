/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

bool run = true;
while (run)
{
    Console.Clear();

    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество колонок массива: ");
    int cols = int.Parse(Console.ReadLine());

    Console.Write("Введите искомое число: ");
    int find = int.Parse(Console.ReadLine());

    int[,] arr = GetArray(rows, cols);
    PrintArray(arr);
    if (FindNum(find, arr)) Console.WriteLine("Есть такое число в массиве");
    else Console.WriteLine("Такого числа в массиве нет");

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

bool FindNum(int num, int[,] array)
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                flag = true;
                break;
            }
        }
    }
    return flag;
}