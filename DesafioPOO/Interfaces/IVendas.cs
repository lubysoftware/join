using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Interfaces
{
    public interface IVendas
    {
       bool EfetuarVenda(double valor, double preco);

        int GetQuantidadeDeVendas();

        double GetTotalVendas();
    }
}
