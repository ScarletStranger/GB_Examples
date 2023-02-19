/*Показывает диапазон координат в заданном квадранте

void ShowRange(int quad)
{
    if (quad == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quad == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quad == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quad == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Incorrect input");
}

Console.WriteLine("Input a number of quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowRange(quadrant);

*/

/*Показывает номер квадранта по заданным точкам

int range(int x, int y)
{
    if (x > 0 && y > 0)
    return 1;
    if (x < 0 && y > 0)
    return 2;
    if (x < 0 && y < 0)
    return 3;
    if (x > 0 && y < 0)
    return 4;
    else
    return -1;
}

Console.WriteLine("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quadrant = range(x, y);
if(quadrant > 0)
Console.WriteLine($"Your coordinates are in {quadrant} quadrant");
else
Console.WriteLine($"Your coordinates are not in any quadrant");
*/

/*Находит расстояние между двумя точками по заданным координатам

double findDistance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

Console.WriteLine("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The distance between given coordinates is " + Math.Round(findDistance(x1, y1, x2, y2), 2));
*/

/*Отображает таблицу квадратов от 1 до n

void SquareTable(int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.WriteLine(index + " - " + Math.Pow(index, 2));
        index++;
    }
}

Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

SquareTable(n);
*/
