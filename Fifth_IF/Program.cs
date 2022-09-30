Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Рады тебе, Маша");
}
else 
{
    Console.Write("Здравствуй, ");
    Console.Write(username);
}