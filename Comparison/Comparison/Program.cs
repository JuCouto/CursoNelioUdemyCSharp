
using Comparison.Entities;


List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

// Opção 1.recebendo a função
/*list.Sort(CompareProducts);
 * 
 * Opção 2
 * Declarar variavel do tipo Comparison recebendo a referencia do metodo que eu criei e passando o comp. como referencia do argumento da função sort.
  Comparison<Product> comp = CompareProducts;

  list.Sort(comp);*/


// FUNÇÂO LAMBDA, apago o método criado anteriormente.
list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

foreach (Product p in list)
{
    Console.WriteLine(p);
}

// Método usado na opção 1 e 2.
/*static int CompareProducts(Product p1, Product p2)
{
    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
}*/