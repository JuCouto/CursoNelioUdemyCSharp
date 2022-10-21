using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//exemplo de ToString, construtor(this), encapsulamento (properties e auto Properties)
namespace CursoNelio
{
    internal class Produto
    {
        //public string Nome { get; set; }
        private string _nome; //no encapsulamento tem q colocar _ antes no nome da propriedade e depois letra minúscula,
                              //não precisa escrever get e set ao lado, declara abaixo como método.

        // public double Preco { get; set; }
        //private double _preco; -----properties normal
        public double Preco { get; private set; } // auto properties, esse método dispensa o método q foi criado abaixo com o get

        //public int Quantidade { get; set; }
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() //o this me indica que vou aproveitar o construtor de cima, no caso a quantidade q está nele
        {
            //Nome = nome;
            //Preco = preco;

            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) // aproveito o construtor de cima
        {
            Quantidade = 10;
        }

        //properties(get e set dentro de um nome de atributo

        public string Nome //método novo, onde eu passava o parametro nome no set agora tenho que chamar de value
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 3)
                    _nome = value;
            }
        }
        //public string GetNome() método antigo
        //    {
        //    return _nome;
        //}

        //public void SetNome(string nome) // posso tratar exceção , método antigo
        //{
        //    if(nome != null && nome.Length >3)
        //    _nome = nome;
        //}

        //public double Preco
        //{
        //    get { return _preco; }
        //}

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return "Produto " + _nome + ", R$" + Preco.ToString("F2") + " " +
                ", "  + Quantidade + " unidades em estoque, Total: R$" + ValorTotalEstoque();
        }
    }
}
