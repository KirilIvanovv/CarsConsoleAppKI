using CarsConsoleApp.Models;
using CarsConsoleApp.Data;


using var context = new AppDbContext();

var car1 = new Car { Brand = "VW", Model = "Passat", Year = 2009, LicensePlate = "JU6360", Color = "White-Gold" };
var car2 = new Car { Brand = "VW", Model = "Touran", Year = 2003, LicensePlate = "HS8111", Color = "Metalic" };

context.Cars.AddRange(car1, car2);
context.SaveChanges();
