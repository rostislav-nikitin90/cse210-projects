namespace Foundation2;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] addresses = new Address[2];
        Customer[] customers = new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        addresses[0] = new Address("1905 W Haskell St", "Tulsa", "Oklahoma", "USA");
        customers[0] =  new Customer("Allan Hart", addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product("Kasa 2K QHD Security Camera","A082", 29.90f, 1));
        productsLists[0].Add(new Product("Jzones Wireless Earbuds Bluetooth Headphones", "B114", 25.20f, 2));
        productsLists[0].Add(new Product("ZEISS Pre-Moistened Wipes, Screen Cleaner", "G074", 15.84f, 1));
        orders[0] = new Order(customers[0], productsLists[0]);

        addresses[1] = new Address("13 Brunswick St", "Melbourne", "Victoria", "Australia");
        customers[1] =  new Customer("Catherine Pike", addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("RAINSMORE Laptop Bag for Women", "C0B7", 18.55f, 1));
        productsLists[1].Add(new Product("Sony - Flash memory card - 1 GB MS PRO DUO", "K00A", 6.98f, 3));
        orders[1] = new Order(customers[1], productsLists[1]);

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Customer N°{i+1} Order");
            Console.WriteLine(orders[i].GetPackingLabel());
            Console.WriteLine(orders[i].GetShippingLabel());
            Console.WriteLine($"Total cost: ${orders[i].GetTotal()}\n\n\n");
        }
    }
}