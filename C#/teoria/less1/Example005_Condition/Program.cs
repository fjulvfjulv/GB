Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "dima")
{
    Console.WriteLine("Привет, пингвин!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}