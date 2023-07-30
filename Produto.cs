using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StockProject
{
    internal class Produto
    {
        public string? Name { get; set; }
        public double Preco { get; private set; }
        public int Quantity { get; private set; }

        public Produto()
        {
            Quantity = 10;
        }

        public Produto(string? name, double preco) : this()
        {
            Name = name;
            Preco = preco;
        }

        public Produto(string? name, double preco, int quantity) : this(name, preco)
        {

        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantity;
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantity += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            Quantity -= qtd;
        }

        public override string ToString()
        {
            return Name 
                + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantity
                + " unidades, Total: $" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
