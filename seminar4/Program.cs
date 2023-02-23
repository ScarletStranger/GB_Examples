/*Сумма чисел от 1 до n
int GetSum (int a)
{
        int result = 0;
        for(int curr = 1; curr <= a; curr++)
//если нужно больше, то используется += 2 и т.д. или -= 2 и т.д.
        {
         result += curr;
        }
        return result;
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0)
{
int result = GetSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} is {result}");
}
else Console.WriteLine("Input a natural number");
*/

/*Находит количество цифр в числе

int Left(int a)
{
    int result = 0;
    for (int curr = 0; a != 0; curr++)
    {
        a = a / 10;
        result++;
    }
    return result;
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0)
{
    int digits = Left(a);
    Console.WriteLine($"The number {a} has {digits} digits");
}
else Console.WriteLine("Input a natural number");
*/

/*Факториал от 1 до n

int Fact (int a)
{
        int result = 1;
        for(int curr = 1; curr <= a; curr++)
        {
         result *= curr;
        }
        return result;
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0)
{
int result = Fact(a);
Console.WriteLine($"Factorial of number {a} is {result}");
}
else Console.WriteLine("Input a natural number");
*/

/*Массив с рандомным размером

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

int[] newArray = RandomArray(size, min, max);
PrintArray(newArray);
*/

