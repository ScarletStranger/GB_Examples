/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Power(int number, int power)
{
    int result = 1;
    for(int count = 0; count < power; count++)
        result *= number;
    return result;
}

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a power: ");
int power = Convert.ToInt32(Console.ReadLine());

int final = Power(number, power);

Console.WriteLine($"{number} to a power of {power} equals {final}");
*/

/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int DigitSum(int number)
{
    int result = 0;
    for (int i = 0; number > 0; i++)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int final = DigitSum(number);

Console.WriteLine($"Sum of digits in {number} equals {final}");
*/

/*Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a number of {i + 1} element: ");
        int a = Convert.ToInt32(Console.ReadLine());
        array[i] = a;
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

int[] newArray = RandomArray(size);
PrintArray(newArray);
*/