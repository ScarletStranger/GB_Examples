
/*БЕЗ МАССИВА Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Quant(int number)
{
    int result = 0;
    int temp = 0;

    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("Input an integer ot input 0 to exit");
        temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0)
            result++;
        if (temp == 0)
            return result;
    }
    return result;
}

Console.WriteLine("Input numbers to count: ");
int number = Convert.ToInt32(Console.ReadLine());

int final = Quant(number);
Console.WriteLine(final);
*/

/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

int cross = (b2 - b1) / (k1 - k2);
Console.WriteLine($"The lines cross at ({cross};{k1 * cross + b1})");
*/