using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address();
        Address address2 = new Address("Eswatini", "Manzini", "Manzini", "Ngwenya ");

        Customer customer = new Customer();
        Customer customer1 = new Customer("John" , address2);

        Product product = new Product();
        Product product1 = new Product("Liquid Soap", "435");
        Product product2 = new Product(10.99, 5);

        Order order = new Order();
        Order order1 = new Order("MDS", "GRD", new List<Product> {product1}, new List<Customer> { customer1});

        // Product product3 = new Product(10.99, 5);
        product1.DisplayProduct();
        Console.WriteLine(order1.GetPackagingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Net Total: {order1.CalculateTotalCost()}");
        Console.WriteLine($"Total cost: {product2.GetTotal()}");


    }
}