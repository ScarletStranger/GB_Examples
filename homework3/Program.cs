
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

double division(double number, double eachNumber)
{
    eachNumber = 0;
    while (eachNumber > 0)
    {
        eachNumber * 10 + number % 10;
        //break;
    }
    
    return (number / 10);
}

Console.WriteLine("Input a number: ");
double number = Convert.ToInt32(Console.ReadLine());
double final = division(number);
Console.WriteLine(final);


//2981891
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