using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
         // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Park Ave", "Sometown", "NY", "USA");
        Address address3 = new Address("789 Beach Blvd", "Seaside", "FL", "USA");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Product 1", 1, 10.50m, 2);
        Product product2 = new Product("Product 2", 2, 15.75m, 1);
        Product product3 = new Product("Product 3", 3, 20.00m, 3);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to orders
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}");
    }
}