
/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[,] CreateRandom2DArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());


    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Convert.Toint(new Random().Nextint()*(new Random().Next(-100, 101)));
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j],2) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
*/

/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2DArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(-100, 101);
    return array;
}

void ElementPosition(int[,] array)
{
    Console.WriteLine("Input element's position in a row: ");
    int iposition = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input element's position in a column: ");
    int jposition = Convert.ToInt32(Console.ReadLine());
    if (iposition < array.GetLength(0) || jposition < array.GetLength(1))
        Console.WriteLine($"Element on {iposition} and {jposition} is {array[iposition - 1, jposition - 1]}");
    else
        Console.WriteLine($"There is no element on {iposition} and {jposition}");
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
ElementPosition(newArray);

*/

/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2DArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimum value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

double Average(int[,] array)
{
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, j];
        }
        result = result / array.GetLength(1);
    }
    return Math.Round(result, 2);
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
Console.Write(Average(newArray));

*/