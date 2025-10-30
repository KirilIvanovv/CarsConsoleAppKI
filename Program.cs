using CarsConsoleApp.Models;
using CarsConsoleApp.Data;


using var db = new AppDbContext();

var CarsBmw = db.Cars
                .Where(c => c.Brand == "Bmw")
                .ToList();

foreach (var car in CarsBmw)
{
    Console.WriteLine($"{car.Brand}, {car.Model}, {car.Year}, {car.Color}, {car.LicensePlate}");
}
Console.WriteLine("---");

var UniqColors = db.Cars
    .Select(c => c.Color)
    .Distinct()
    .ToList();

foreach (var car in UniqColors)
{
    Console.WriteLine($"{car}");
}
Console.WriteLine("---");

var Cars2010 = db.Cars
    .Where(c => c.Year >= 2010)
    .ToList();

foreach (var car in Cars2010)
{
    Console.WriteLine($"{car.Brand}, {car.Model}, {car.Year}");
}
Console.WriteLine("---------------");

Console.Write("Input color: ");
string color = Console.ReadLine();

var CarsColor = db.Cars
    .Where(c => c.Color ==  color)
    .ToList();

foreach (var car in CarsColor)
{
    Console.WriteLine($"{car.Brand}, {car.Model}, {car.Color}");
}
Console.WriteLine("---------------");

Console.Write("Cars made after: ");
int year = int.Parse(Console.ReadLine());

var CarsAfter = db.Cars
    .Where( c =>  c.Year > year)
    .ToList();

foreach(var car  in CarsAfter)
{
    Console.WriteLine($"{car.Brand}, {car.Model}, {car.Year}");
}
Console.WriteLine("---------------");

Console.WriteLine("Enter the client name");
string name = Console.ReadLine();

var ClientName = db.Customers
    .Where(c =>c.Name == name)
    .ToList();

if(ClientName != null)
{
    Console.WriteLine($"Client found");
}
else
{
    Console.WriteLine($"Client not found");
}










