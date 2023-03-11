
/* Меняет строки массива местами
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

void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0) &&
        row2 >= 0 && row2 < array.GetLength(1) &&
        row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);

Console.Write("Input a first row to change ");
int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input a second row to change ");
int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

ChangeRows(newArray, r1, r2);
Show2DArray(newArray);
*/

/* Меняет строки и столбцы местами

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

void ChangeRowsColumns(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
    }
    else
        Console.WriteLine("Incorrect data");
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);

ChangeRowsColumns(newArray);
Show2DArray(newArray);
*/

/* Удалить строку и столбец, на пересечении которых расположен наименьший элемент

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

int[] FindMinPosition(int[,] array)
{
    int[] result = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[result[0], result[1]])
            {
                result[0] = i;
                result[1] = j;
            }
    return result;
}

int[,] RowColumnDeletion(int[,] array, int row, int column)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0, newi = 0; i < array.GetLength(0); i++)
        if (i != row)
        {
            for (int j = 0, newj = 0; j < array.GetLength(0); j++)

                if (j != column)
                {
                    result[newi, newj] = array[i, j];
                    newj++;
                }
            newi++;
        }
    return result;
}

int[,] array = CreateRandom2DArray();
Show2DArray(array);

int[] MinPosition = FindMinPosition(array);
int[,] newArray = RowColumnDeletion(array, MinPosition[0], MinPosition[1]);
Show2DArray(newArray);
*/