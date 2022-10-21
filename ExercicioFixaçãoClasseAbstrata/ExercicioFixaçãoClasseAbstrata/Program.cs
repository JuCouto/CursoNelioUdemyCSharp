using System.Globalization;
using ExercicioFixaçãoClasseAbstrata;

List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int number = int.Parse(Console.ReadLine());

for(int i=1; i <= number; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");

    Console.Write("Individual or company (i/c)? ");
    char payer = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (payer == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Individual(name, income, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse((Console.ReadLine()));
        list.Add(new Company(name, income, numberOfEmployees));
    }
}

double result = 0.0;
Console.WriteLine("TAXES PAID:");
foreach (TaxPayer taxPayer in list)
    {
    double tax = taxPayer.Tax();
    Console.WriteLine(taxPayer.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
    result += tax;
}
Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ " + result.ToString("F2", CultureInfo.InvariantCulture));