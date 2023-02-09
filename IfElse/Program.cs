Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "олеся")
{
    Console.WriteLine("Ура, это уже ОЛЕСЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}