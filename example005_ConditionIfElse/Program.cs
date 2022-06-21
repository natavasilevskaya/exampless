Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "ната")
{
    Console.WriteLine("Ура, это же Ната!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}