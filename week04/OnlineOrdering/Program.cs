using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "P100", 3.50m, 4));
        order1.AddProduct(new Product("Pen", "P200", 1.25m, 10));

        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Lee", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "P300", 45.00m, 1));
        order2.AddProduct(new Product("Water Bottle", "P400", 12.00m, 2));

        DisplayOrder(order1);
        Console.WriteLine("----------------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}\n");
    }
}
