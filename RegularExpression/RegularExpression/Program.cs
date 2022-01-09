// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");


string name = "James Jackson";

if (name.Contains("James"))
{
    Console.WriteLine("Hey James :)");
}




Regex phonePattern = new Regex(@"^(\d{1,3}( |-))?(((\(\d{3}\))|\d{3})( |-))?\d{3}( |-)\d{4}$");
if (phonePattern.IsMatch("123 345 3224"))
{
    Console.WriteLine("We created a valid phone number!");
}
