
/* Задайте число n и напишите программу, которая выведет все числа от 1 до n

void ShowCount(int n)
{
    Console.Write(n + " ");
    if(n > 0)
    {
    ShowCount(n - 1);
    Console.Write(n + " ");
    }
    else Console.WriteLine("Incorrect data");
}

Console.WriteLine("What number do you want to count to?");
int n = Convert.ToInt32(Console.ReadLine());

ShowCount(n);
*/

/*

int DigitSum(int n)
{
    if (n / 10 != 0) return DigitSum(n / 10) + n % 10;
    return n;
}

Console.WriteLine("What number do you want to count to?");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DigitSum(n));
*/

/* Отображает числа от n до m и наоборот
void ShowCount(int n, int m)
{
    if (n > m) ShowCount(n, m+1);
    if(n<m) ShowCount(n,m-1);
    Console.Write(m + " ");
}

Console.WriteLine("Input a number to start counting");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number to finish counting");
int m = Convert.ToInt32(Console.ReadLine());

ShowCount(n, m);

*/

/* Задайте a и b. Число a возводится в степень b.

double NumPower(int n, int power)
{
    if (power == 0) return 1;
    else
    {
        if(power > 0)
        return NumPower(n, power - 1) * n;
        else
        return NumPower(n, power + 1) / n;
    }
}

Console.WriteLine("Input a number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a power");
int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{n} to a power of {power} eauals {NumPower(n, power)}");
*/
