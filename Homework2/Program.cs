/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int res (int num)
{
    int result = (num / 10) % 10;
    return result;
}

int random = new Random().Next(100, 1000);
int second = res(random);
Console.Write($"The second number of {random} is {second}");
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


bool ThreeOrNo(string strNumber)
{
    return(strNumber != null && strNumber.Length > 2);
}

Console.WriteLine("Input a number ");
string strNumber = Console.ReadLine();
bool result = ThreeOrNo(strNumber);

if(result)
Console.WriteLine($"A third number of {strNumber} is {strNumber[2]}");
else
Console.WriteLine($"{strNumber} doesn't have a third number");
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool IsWeekend(int weekday)
{
    return (weekday == 6 || weekday == 7);
}

int weekday = new Random().Next(1, 8);
bool result = IsWeekend(weekday);

if(result)
Console.WriteLine($"{weekday} is a weekend");
else
Console.WriteLine($"{weekday} is not a weekend");
*/