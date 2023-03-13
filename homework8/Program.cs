/* Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

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

void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
}

int[,] array = CreateRandom2DArray();
Show2DArray(array);

SelectionSort(array);
Show2DArray(array);
*/

/* Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и
выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int RowSum(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int[,] array = CreateRandom2DArray();
Show2DArray(array);

int minSumLine = 0;
int sumLine = RowSum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = RowSum(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"Row with the smallest sum of {sumLine} is {minSumLine + 1} ");
*/

/* Задайте две матрицы. Напишите программу, которая
будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/* Сформируйте трёхмерный массив из
неповторяющихся двузначных чисел.
Напишите программу, которая будет
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

int TwoDigit()// доделать генерацию НЕПОВТОРЯЮЩИХСЯ двузначных чисел
{
    int n = 0;
    for (int count = 10; count < 100; count = count + 2)
    {
        n = new Random().Next(10, 100);
    }
    return n;
}

int[,,] CreateRandom3DArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of layers: ");
    int layers = Convert.ToInt32(Console.ReadLine());


    int[,,] array = new int[rows, columns, layers];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < layers; k++)
                array[i, j, k] = TwoDigit();
    return array;
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"{i+1} layer");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + $"({i},{j},{k})" + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array = CreateRandom3DArray();
Show3DArray(array);

*/

/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] CreateSpiral2DArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1,2);
    return array;
}

int[,] SpiralArray(int[,] array)
{

    int temp = 1;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            while (temp <= array.GetLength(0) * array.GetLength(1))
            {
                array[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= array.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > array.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }
    return array;
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

int[,] newArray = CreateSpiral2DArray();
int[,] spiral = SpiralArray(newArray);
Show2DArray(spiral);
