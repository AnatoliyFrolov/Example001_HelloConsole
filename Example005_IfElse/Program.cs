Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
   Console.WriteLine("Наконец-то Маша пришла");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}