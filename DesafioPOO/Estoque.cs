using DesafioPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
   public class Estoque : IEstoque
    {
        List<Produto> ListaDeEstoque = new List<Produto>();

        public void AdicionarProduto(string nome, int quantidade, double preco)
        {
            ListaDeEstoque.Add(new Produto { Nome = nome, Quantidade = quantidade, Preco = preco});
        }

        public List<Produto> GetEstoque()
        {
            return ListaDeEstoque;
        }
    }
}
