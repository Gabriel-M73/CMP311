// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("This is cool!");

Console.WriteLine("Enter Name");
string username = Console.ReadLine();
Console.WriteLine("Name is " + username);

Console.WriteLine("Enter integer b//w 1 - 10");
int num = Convert.ToInt32(Console.ReadLine());

do
if (num < 1 || num > 10)
{
    Console.WriteLine("Invalid integer, try again"); 
} while (num < 1 || num > 10)
    {
    num = Convert.ToInt32(Console.ReadLine()); // int32.Parse also works
}