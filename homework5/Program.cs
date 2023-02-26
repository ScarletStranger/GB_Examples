
/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

int Even(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    if(array[i] % 2 == 0)
    count++;
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] newArray = RandomArray(size);
PrintArray(newArray);

int total = Even(newArray);
Console.WriteLine($"There are {total} even numbers in an array");
*/

/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

int OddSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
        sum = array[i] + sum;
    return sum;
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

int total = OddSum(newArray);
Console.WriteLine($"Sum of all odd numbers in an array eauals {total}");
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

int Difference(int[] array)
{
    int min = array[0];
    int max = array[0];
    int diff = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    return diff = max - min;
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

int result = Difference(newArray);
Console.WriteLine($"Difference between the smallest and the largest number is {result}");