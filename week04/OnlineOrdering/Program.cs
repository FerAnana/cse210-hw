using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("Street", "City", "St", "USA");
        Customer usaCustomer = new Customer("Sophia Nievas", usaAddress);

        Product p1 = new Product("Mouse", "436101", 15.50m, 2);
        Product p2 = new Product("Keyboard", "745202", 75.99m, 1);

        List<Product> products1 = new List<Product> { p1, p2 };
        Order order1 = new Order(products1, usaCustomer);

        Console.WriteLine("USA Customer (Shipping: $5.00)");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotal():F2}\n");

        Address notUsaAddress = new Address("Calle", "Ciudad", "País", "NotUsa");
        Customer notUsaCustomer = new Customer("Fernando Añaña", notUsaAddress);

        Product p3 = new Product("Webcam HD", "452303", 45.00m, 3);
        Product p4 = new Product("USB-C Hub", "912404", 22.25m, 1);
        Product p5 = new Product("Monitor Stand", "378505", 10.00m, 5);

        List<Product> products2 = new List<Product> { p3, p4, p5 };
        Order order2 = new Order(products2, notUsaCustomer);

        Console.WriteLine("\nNot USA Customer (Shipping: $35.00)");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotal():F2}");
    }
}