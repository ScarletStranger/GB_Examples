/*string[,] table = new string[2, 5];//первое число(2) - строки, второе(5) - столбцы
//вид данного массива:
//столбцы - table [0,0] table[0,1] table [0,2] table [0,3] table [0,4] 
//строки - table [1,0] 

table[1, 2] = "слово";//первое число(1) - индекс строки, второе(2) - индекс столбца

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"+{table[rows, columns]}+");
    }
}
*/

/*void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

/*double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Fibonacci(i));
}