using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Interfaces
{
    public interface IEstoque
    {
        public void AdicionarProduto(string nome, int quantidade, double preco);

        public List<Produto> GetEstoque();
    }
}
