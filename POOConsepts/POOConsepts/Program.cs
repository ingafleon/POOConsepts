// See https://aka.ms/new-console-template for more information
using POOConsepts;

Console.WriteLine("POO Consepts!");
Console.WriteLine("============");
try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1978, 10, 22));
	Console.WriteLine(new Date(1999, 9, 16));
	Console.WriteLine(new Date(2011, 6, 29));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}

