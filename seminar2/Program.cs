/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;
    int result = hundreds * 10 + units;
    return result;
}

int random = new Random().Next(100, 1000);
int newNumber = CutNumber(random);
Console.WriteLine($"New vesrion of {random} is {newNumber}");
*/

/*
bool IsMultiplied(int num, int div1, int div2)
{
    if (num % div1 == 0 && num % div2 == 0)
        return true;
    else
        return false;
}
// Оба варианты рабочие
bool IsMultipliedBest(int num, int div1, int div2)
{
    return num % div1 == 0 && num % div2 == 0;
}
*/

/*
bool IsMultipliedBest(int num, int div1, int div2)
{
    return num % div1 == 0 && num % div2 == 0;
}

Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool result = IsMultipliedBest(number, divider1, divider2);

if(result)
Console.WriteLine($"Your number {number} is divisible by {divider1} and {divider2}");
else
Console.WriteLine($"Your number {number} is not divisible by {divider1} and {divider2}");
*/

//Выводит случайное число от 10 до 99 и показывает цифру наибольшего числа

/*
int GreatestNum(int num)
{
    int tens = num / 10;
    int units = num % 10;
    if (units > tens)
        return units;
    else
        return tens;
}
int random = new Random().Next(10, 100);
int big = GreatestNum(random);
Console.WriteLine($"The biggest digit of {random} is {big}");
*/

//Является ли одно число квадратом другого

/*
bool IsSquare(int num1, int num2)
{
    return (num1 / num2 == num2 || num2 / num1 == num1);
}
Console.Write("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(num1, num2);
if (result)
    Console.WriteLine($"Number {num1} or number {num2} is a square of other number");
else
    Console.WriteLine($"Number {num1} or number {num2} is not a square of other number");
*/
