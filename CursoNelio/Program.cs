using System;
using System.Globalization;

namespace CursoNelio // Modelo clássico de escrever o programa C#, a partir do C# 10, é só escrever a linha de código
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estudo parte 1 **********************************

            //string nome = "Carlos";
            //int idade = 23;
            //char letra = '\u0041'; //imprimir caracter unicode. ´Procurar no google tabela com códigos, esse código usado foi referente ao A.
            //double saldo = 10.5896355;

            // Console.WriteLine(letra);
            //Console.WriteLine(  saldo.ToString("F2")); //delimita o numero de casas decimais
            //Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));//ignora a padronização de país, no caso o brasil utiliza ',  virgula ' para valor
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2}", nome, idade, saldo);//placeholder
            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2}");//interpolação
            //Console.WriteLine(nome + "tem " + idade + "anos e tem saldo igual a" + saldo.ToString("F2"));//concatenação

            //int n1 = int.Parse(Console.ReadLine()); //converte a string que vai ser digitada em um tipo inteiro



            //ESTUDO TOSTRING ***************************************

            //Produto p = new Produto();

            //Console.WriteLine("Entre os dados do produto: ");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //p.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados:" + p);

            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados:" + p);





            //ESTUDO STATIC**********************************************************

            //Console.WriteLine("Qual a cotação do dólar hoje? ");
            //double cotacao = double.Parse(Console.ReadLine());

            //Console.WriteLine("Quantos dólares você vai comprar? ");
            //double quantia = double.Parse(Console.ReadLine());

            //double result = ConversorDeMoeda.DolarParaReal(cotacao, quantia);

            //Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2"));



            //PARAMS ************************************************************************

            //int s1 = Calculadora.Sum(2, 3);//não precisa instanciar pq esta usando params na declaração da função

            //Console.WriteLine(s1);





            //Evitar usar ref e out ************************************************

            //REF*************************************************************************

            //    int a = 10;
            //    Calculadora.Triple( ref a);//usar o ref aqui vai referenciar a memória stack
            //    Console.WriteLine(a);
            //}


            //OUT ********************************************************************************
            //int a = 10;
            //int triple;
            //Calculadora.Triple(a, out triple);
            //Console.WriteLine(triple);


            //FIND  (LISTAS) LAMBDA ***************************************

            //    List<string> list = new List<string>();
            //    list.Add("Maria");
            //    list.Add("Alex");
            //    list.Add("Bob");
            //    list.Add("Anna");
            //    list.Insert(2, "Marco");

            //    foreach (string obj in list)
            //    {
            //        Console.WriteLine(obj);
            //    }
            //    Console.WriteLine("List count: " + list.Count);

            //    //Encontrar primeiro ou último elementos da lista que satisfaça um predicado:

            //    string s1 = list.Find(x => x[0] == 'A'); // expressão lambda
            //    Console.WriteLine("First 'A': " + s1);

            //    string s2 = list.FindLast(x => x[0] == 'A');
            //    Console.WriteLine("Last 'A': " + s2);

            //    //Encontrar primeira ou última posição de elemento da lista que satisfaça um
            //    //predicado

            //    int pos1 = list.FindIndex(x => x[0] == 'A');
            //    Console.WriteLine("First position 'A': " + pos1);
            //    int pos2 = list.FindLastIndex(x => x[0] == 'A');
            //    Console.WriteLine("Last position 'A': " + pos2);

            //    //Filtrar a lista com base em um predicado:

            //    List<string> list2 = list.FindAll(x => x.Length == 5);
            //    Console.WriteLine("---------------------");
            //    foreach (string obj in list2)
            //    {
            //        Console.WriteLine(obj);
            //    }

            //    //Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange

            //    list.Remove("Alex");
            //    Console.WriteLine("---------------------");
            //    foreach (string obj in list)
            //    {
            //        Console.WriteLine(obj);
            //    }
            //    list.RemoveAll(x => x[0] == 'M');
            //    Console.WriteLine("---------------------");
            //    foreach (string obj in list)
            //    {
            //        Console.WriteLine(obj);
            //    }

            //    list.RemoveRange(2,2);  que passar a posição do Item e quantos serão removidos a partir dele



            //MATRIZ*****************************************************************************

            /* double[,] mat = new double[2, 3]; // forma de representar a matriz
             Console.WriteLine(mat.Length);//tamanho da matriz no total
             Console.WriteLine(mat.Rank);//qual a quantidade de linhas da matriz
             Console.WriteLine(mat.GetLength(0));//quantidade de linhas da matriz
             Console.WriteLine(mat.GetLength(1));//quantidade de colunas da matriz*/

            /*Console.Write("Digite o numero de casas da sua matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);

            //exercicio 2

            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }*/



        }
    }
}
