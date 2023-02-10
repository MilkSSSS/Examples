Console.WriteLine("Put your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("URA! It's Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}