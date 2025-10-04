using CarsConsoleApp.Models;
using CarsConsoleApp.Data;


using var context = new AppDbContext();

while (true)
{
    Console.WriteLine("1- Output all data");
    Console.WriteLine("2- Add car");
    Console.WriteLine("3- Add customer");
    Console.WriteLine("4 - Add order");

    Console.WriteLine("Exit: 0");
    string userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
            ShowAllData(context);
            break;
        case "2":
            AddCar(context);
            break;
        case "3":
            AddCustomer(context);
            break;
        case "4":
            AddOrder(context);
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
        Console.WriteLine($"Year: {car.Year}");
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

static void AddCar(AppDbContext context)
{
    Console.Write("Input brand: ");
    string brand = Console.ReadLine();
    Console.Write("Input model: ");
    string model = Console.ReadLine();
    Console.Write("Input license plate: ");
    string licensePlate = Console.ReadLine();
    Console.Write("Input year: ");
    int year = int.Parse(Console.ReadLine());
    Console.Write("Input color: ");
    string color = Console.ReadLine();

    var newCar = new Car { Brand = brand, Model = model, LicensePlate = licensePlate, Year = year, Color = color };

    context.Cars.Add(newCar);
    context.SaveChanges();

    Console.WriteLine("Car added");


}

static void AddCustomer(AppDbContext context)
{
    Console.Write("Input name: ");
    string name = Console.ReadLine();
    Console.Write("Input email: ");
    string email = Console.ReadLine();
    Console.Write("Input phone number: ");
    string phone = Console.ReadLine();

    var newCustomer = new Customer { Name = name, Email = email, Phone = phone };

    context.Customers.Add(newCustomer);
    context.SaveChanges();

    Console.WriteLine("Customer added");
}

static void AddOrder(AppDbContext context)
{
    Console.Write("Input Car ID: ");
    int carId = int.Parse(Console.ReadLine());
    Console.Write("Input Customer ID: ");
    int customerId = int.Parse(Console.ReadLine());
    Console.Write("Input description: ");
    string description = Console.ReadLine();
    Console.Write("Input total cost: ");
    decimal totalCost = decimal.Parse(Console.ReadLine());

    var newOrder = new Order
    {
        CarId = carId,
        CustomerId = customerId,
        OrderDate = DateTime.Now, 
        Description = description,
        TotalCost = totalCost
    };

    context.Orders.Add(newOrder);
    context.SaveChanges();

    Console.WriteLine("Order added");
}