using System;
 
class Program
{
    static void Main(string[] args)
    {
        // Order 1: Customer in the USA ($5 shipping)
        Address address1 = new Address("6801 Hollywood blvd", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("Elmorya Messiah", address1);
        Order order1 = new Order(customer1);
 
        order1.AddProduct(new Product("Smart Fitness Watch", "SFW-110", 149.99, 1));
        order1.AddProduct(new Product("Insulated Water Bottle", "IWB-204", 24.50, 2));
        order1.AddProduct(new Product("Wireless Charging Pad", "WCP-315", 29.99, 1));
 
        Console.WriteLine("=========================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("=========================================\n");
 
        // Order 2: International Customer ($35 shipping)
        Address address2 = new Address("45 Oron Road", "Uyo", "Akwa Ibom", "Nigeria");
        Customer customer2 = new Customer("Edidiong Bassey", address2);
        Order order2 = new Order(customer2);
 
        order2.AddProduct(new Product("Solar Power Bank 20000mAh", "SPB-401", 45.00, 2));
        order2.AddProduct(new Product("Bluetooth Portable Speaker", "BPS-518", 65.50, 1));
 
        Console.WriteLine("=========================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("=========================================");
    }
}
 
 