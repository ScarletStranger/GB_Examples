/* Вид 1
void Method1()
{
    Console.WriteLine("Hello world");
}
//Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Text");

void Method3(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method3(msg: "Text", 4);
//или
//Method3(count: 4, msg: "Text");

// Вид 3

int Method4()
{
    return DateTime.Now.Year;
}
int year = Method4();
//Console.WriteLine(year);

// Вид 4
string Method5(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method5(10, "qwerrt");
Console.WriteLine(res);
*/

string Method5(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method5(10, "qwerrt");
Console.WriteLine(res);