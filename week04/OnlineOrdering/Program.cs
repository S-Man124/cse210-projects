
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ONLINE ORDERING SYSTEM");
        Console.WriteLine("======================");
        Console.WriteLine();

        // ORDER 1: Customer in the USA
        Address address1 = new Address(
            "123 Main Street",
            "Salt Lake City",
            "Utah",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith", address1
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product(
            "Laptop", "P001", 850.00, 1
        ));

        order1.AddProduct(new Product(
            "Wireless Mouse", "P002", 25.00, 2
        ));

        order1.AddProduct(new Product(
            "USB-C Cable", "P003", 15.00, 3
        ));

        // ORDER 2: Customer in South Africa
        Address address2 = new Address(
            "45 Nelson Mandela Drive",
            "Johannesburg",
            "Gauteng",
            "South Africa"
        );

        Customer customer2 = new Customer(
            "Thabo Mokoena", address2
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product(
            "Gaming Keyboard", "P004", 75.00, 1
        ));

        order2.AddProduct(new Product(
            "External SSD", "P005", 120.00, 2
        ));

        order2.AddProduct(new Product(
            "HD Webcam", "P006", 65.00, 1
        ));

        // Display both orders
        Console.WriteLine("ORDER 1 - USA CUSTOMER");
        Console.WriteLine("----------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(
            $"TOTAL PRICE: ${order1.CalculateTotal():F2}"
        );

        Console.WriteLine();
        Console.WriteLine("======================");
        Console.WriteLine();

        Console.WriteLine("ORDER 2 - INTERNATIONAL CUSTOMER");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(
            $"TOTAL PRICE: ${order2.CalculateTotal():F2}"
        );
    }
}
