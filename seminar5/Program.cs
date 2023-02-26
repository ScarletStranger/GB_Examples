/*Создать массив из 12 элементов и найти сумму отрицательных элементов

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

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];
    return sum;
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(size, min, max);
PrintArray(newArray);

int result = GetSum(newArray);
Console.WriteLine("Sum of negatives is " + result);
*/

/*Программа замены отрицательных элементов массива на положительные и наоборот

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

int [] Change(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    array[i] *= -1;
    }
    return array;
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
PrintArray(Change(newArray));
*/

/*Присутствует ли заданное число в массиве

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

bool Number(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    if(array[i]== number)
    return true;
    return false;
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
Console.WriteLine("Input a number you want to find in an array: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(size, min, max);
PrintArray(newArray);
if(Number(newArray,number))
Console.WriteLine($"Your number {number} is in an array");
else
Console.WriteLine($"Your number {number} is not in an array");
*/

/*Создать массив из случайных чисел и найти количество чисел в отрезке от a до b

int Count (int[] array, int a, int b)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    if(array[i] >= a && array[i] <= b)
    result ++;
    return result;
}

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

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a minimum value of an element: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a maximum value of an element: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(size, min, max);
PrintArray(newArray);

int count = Count (newArray, a, b);
Console.WriteLine($"There are {count} numbers beetween {a} and {b}");
*/