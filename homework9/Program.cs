
/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Nums(int n)
{
    Console.Write(n + " ");
    if (n == 1) Console.Write(n + " ");
    else
    {
        Nums(n - 1);
        Console.Write(n + " ");
    }
}

Console.Write("Input a numer to count from ");
int n = Convert.ToInt32(Console.ReadLine());

Nums(n);
*/

/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Console.Write("Input a first number ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int n = Convert.ToInt32(Console.ReadLine());

SumMtoN(m, n);

void SumMtoN(int m, int n)
{
    Console.Write(Nums(m - 1, n));
}

int Nums(int m, int n)
{
    int sum = m;
    if (m == n) return 0;
    else
    {
        m++;
        sum = m + Nums(m, n);
        return sum;
    }
}
*/

/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m, n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    else return (Akkerman(m - 1, Akkerman(m, n - 1)));
}
*/