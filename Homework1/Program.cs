//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
Console.WriteLine("The greatest number is " + n1);
Console.WriteLine("The smallest number is " + n2);
}
else
{
Console.WriteLine("The greatest number is " + n2);
Console.WriteLine("The smallest number is " + n1);
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    if (n1 > n3)
    {
    Console.WriteLine("The greatest number is " + n1);
    }
}
else
{
     if (n2 > n3)
     {
    Console.WriteLine("The greatest number is " + n2);
     }
     else
     {
    Console.WriteLine("The greatest number is " + n3);
     }  
}
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if(n1 % 2 == 0)
Console.WriteLine("The number is even");
else
Console.WriteLine("The number is odd");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= n1)
{
    if(count % 2 == 0)
    {
    Console.Write(count + " ");
    count++;
    }
    else
    {
    count++;
    }
}
