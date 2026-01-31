using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1912 Gurupi", "Amazonas", "AM", "Brasil");
        Customer customer1 = new Customer("Swuamy Santos", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "P111", 30, 1));
        order1.AddProduct(new Product("Mouse", "P222", 20, 2));

        Address address2 = new Address("456 Maple Bear Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Ana Silva", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P333", 50, 1));
        order2.AddProduct(new Product("Webcam", "P444", 70, 1));

        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
    }
}
