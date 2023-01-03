Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();
if (username is not null) // прописал для удаления ошибки
{
    if (username.ToLower() == "маша") // .ToLower() - переводит все символы строки в нижний регистр
    {
        Console.WriteLine("Ура, это же Маша!!!");
    }

    else
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    }
}