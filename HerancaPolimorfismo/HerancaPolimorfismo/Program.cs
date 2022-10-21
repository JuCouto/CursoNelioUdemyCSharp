using HerancaPolimorfismo.Entities;
using System.Globalization;


List<Product> list = new List<Product>();

Console.Write("Enter the number of products: ");
int number = int.Parse(Console.ReadLine());

for(int n = 1; n<= number; n++)
{
    Console.WriteLine($"Product #{n} data:");
    
    Console.Write("Common, used or imported (c/u/i)?");
    char chose = char.Parse(Console.ReadLine());
    
    Console.Write("Name: ");
    String name = Console.ReadLine();
    
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (chose == 'c')
    {
        list.Add(new Product(name, price));
    }
    else if (chose == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, date));
    }
    else
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new ImportedProduct(name, price, customsFee));
    }

}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach (Product prod in list)
{
    Console.WriteLine(prod.PriceTag());
}

