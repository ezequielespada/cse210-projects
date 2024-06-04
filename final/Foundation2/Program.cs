using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Producs
        Product product1 = new Product("Laptop", "P001", 1000, 2);
        Product product2 = new Product("Mouse", "P002", 50, 3);
        Product product3 = new Product("Keyboard", "P003", 80, 1);
        Product product4 = new Product("Monitor", "P004", 300, 1);
        Product product5 = new Product("Desk Lamp", "P005", 20, 5);

        // Customers and address
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Address address2 = new Address("456 Elm St", "Vancouver", "BC", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Show detail order
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.CalculateTotalCost()}");
            Console.WriteLine();
        }
    }
}