// See https://aka.ms/new-console-template for more information
using app;

Console.WriteLine("Hello, World!");
Console.WriteLine("rahul");
Console.WriteLine("nana");

Console.WriteLine("Welcome TO Calculater");

Console.WriteLine("Please enter first number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter second number");
int b = int.Parse(Console.ReadLine());


Calculater c = new Calculater();
c.Add(a,b);

Console.ReadLine();