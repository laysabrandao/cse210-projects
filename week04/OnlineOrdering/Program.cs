using System;

class Program
{
    static void Main(string[] args)
    {
        //create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("45 Queen St", "Toronto", "ON", "Canada");


        //create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Emily Johnson", address2);


        //create orders
        Order order1 = new Order(customer1);
        order1.AddProduct("Laptop", 1001, 999.99, 1);
        order1.AddProduct("Mouse", 1002, 25.50, 2);
        Order order2 = new Order(customer2);
        order2.AddProduct("Desk Chair", 2001, 150.75, 1);
        order2.AddProduct("Monitor", 2002, 220.00, 2);
        order2.AddProduct("Keyboard", 2003, 45.99, 1);


        //display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}