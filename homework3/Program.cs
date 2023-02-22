/*Напишите программу, которая принимает на вход пятизначное(или нет) число и проверяет, является ли оно палиндромом.

bool IsPalindrome(int number)
{
    if (number < 0 || (number % 10 == 0 && number != 0))
    return false;

    int revertedNumber = 0;
    while (number > revertedNumber)
    {
        revertedNumber = revertedNumber * 10 + number % 10;
        number = number / 10;
    }
    return number == revertedNumber || number == revertedNumber / 10;
}

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(number))
    Console.WriteLine($"The number {number} is a palindrome");
else
    Console.WriteLine($"The number {number} is not a palindrome");
*/

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double findDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return (Math.Sqrt((x2 - x1) * (x2 - x1) * (z2 - z1) + (y2 - y1) * (y2 - y1) * (z2 - z1)));
}

Console.WriteLine("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The distance between given coordinates is " + Math.Round(findDistance(x1, y1, z1, x2, y2, z2), 2));
*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void SquareTable(int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.WriteLine(index + " - " + Math.Pow(index, 3));
        index++;
    }
}

Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

SquareTable(n);

*/