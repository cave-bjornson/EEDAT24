using System.Globalization;

string name = "Bjorn";
int y = 2;
double pi = 3.14;

Console.WriteLine("Hello " + name);
Console.WriteLine(2 + y);
Console.WriteLine("Skriv in värdet på pi med 2 decimaler");
var answer = Console.ReadLine();
if (double.Parse(answer, CultureInfo.InvariantCulture) == pi)
{
    Console.WriteLine("Correct!");
}