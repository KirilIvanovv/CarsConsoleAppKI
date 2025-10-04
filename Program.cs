using CarsConsoleApp.Models;
using CarsConsoleApp.Data;


using var context = new AppDbContext();

while (true)
{
    Console.WriteLine("Output all data: 1");
    Console.WriteLine("Add car: 2");
    Console.WriteLine("Add client: 3");

    Console.WriteLine("Exit: 0");
    string userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
            ShowAllData(context);
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Error");
            break;
    }
}

static void ShowAllData(AppDbContext context)
{
    var customers = context.Customers.ToList();

    foreach (var customer in customers)
    {
        Console.WriteLine($"ID: {customer.Id}");
        Console.WriteLine($"Name: {customer.Name}");
        Console.WriteLine($"Email: {customer.Email}");
        Console.WriteLine($"Phone: {customer.Phone}");
        Console.WriteLine(" ");
    }
    Console.WriteLine("--------");

    var cars = context.Cars.ToList();

    foreach (var car in cars)
    {
        Console.WriteLine($"ID: {car.Id}");
        Console.WriteLine($"Brand: {car.Brand}");
        Console.WriteLine($"Model: {car.Model}");
        Console.WriteLine($"LicensePlate: {car.LicensePlate}");
        Console.WriteLine(" ");
    }
    Console.WriteLine("--------");

    var orders = context.Orders.ToList();

    foreach (var order in orders)
    {
        Console.WriteLine($"CarID: {order.CarId}");
        Console.WriteLine($"CustomerID: {order.CustomerId}");
        Console.WriteLine($"OrderDate: {order.OrderDate}");
        Console.WriteLine($"Description: {order.Description}");
        Console.WriteLine($"TotalCost: {order.TotalCost}");
        Console.WriteLine(" ");
    }

}