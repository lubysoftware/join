using DesafioPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Vendas : IVendas
    {
        public double ValorTotal { get; set; }

        public int QuantidadeDeVendas { get; set; }

        public bool EfetuarVenda(double valor, double preco)
        {
            //double valortratado = Convert.ToDouble(valor);


            if (preco > valor)
            {
                Console.WriteLine("O troco é: "
                   + (preco - valor) +
                   "Obrigado por comprar conosco");



            }

            ValorTotal =  ValorTotal + preco;
            QuantidadeDeVendas++;

            return true;

        }

         public int GetQuantidadeDeVendas()
        {
            return QuantidadeDeVendas;
        }

        public double GetTotalVendas()
        {
            return ValorTotal;
        }
    }
}
