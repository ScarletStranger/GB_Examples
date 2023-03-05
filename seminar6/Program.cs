/*
int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for (int i = 0, a = array.Length - 1; i < a; i++, a--)
    {
        int temp = array[i];
        array[i] = array[a];
        array[a] = temp;
    }
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(size, min, max);
PrintArray(newArray);
ReverseArray(newArray);
PrintArray(newArray);
*/

/*Принимает три числа и проверяет может ли существовать такой треугольник

bool TriangleCheck(int a, int b, int c)
{
    if (a <= b + c && b <= a + c && c <= a + b)
        return true;
    return false;
}

Console.WriteLine("Input a : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (TriangleCheck(a, b, c))
    Console.WriteLine($"Triangle with {a}, {b} and {c} exists");
else
    Console.WriteLine($"Triangle with {a}, {b} and {c} does not exist");
*/

/*Без рекурсии вывести n чисел Фибоначчи (0 1 1 2 5 8 13)

int[] Array(int size, int a, int b)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < size; i++)
        array[i] = array[i-1]+array[i-2];
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

PrintArray(Array(size, a, b));
*/

/*Создаёт копию массива с помощью поэлементного копирования

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

int[] ArrayCopy(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        newArray[i] = array[i];
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(size, min, max);
PrintArray(newArray);
PrintArray(ArrayCopy(newArray));
*/

//Преобразовывает десятичное число в двоичное

string Double(int n)
{
    string result = "";
    for (int i = 0; n > 0; i++)
    {
        if (n % 2 == 0)
        {
            result = "0";
            n = n/2;
        }
        else
        {
            result = "1";
            n = n/2;
        }
    }
    return result;
}

Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Double(n));