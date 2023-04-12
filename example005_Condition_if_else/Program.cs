Console.WriteLine("Введите имя пользователя: ");
string userName = Console.ReadLine() ?? "";

if (userName.ToLower() == "настасья")
{
    Console.WriteLine("Ура! это же Настасья!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}