Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ариана")
{
    Console.WriteLine("Ура!!! Это же Ариана!!!");
} 
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}