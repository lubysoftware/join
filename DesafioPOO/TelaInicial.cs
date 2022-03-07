using DesafioPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class TelaInicial
    {
        private static IVendas vendasTela;

        private static IEstoque estoqueTelas;

     
        public static void TelaInicialEstatica()
        {
            var TelaView = new View(estoqueTelas, vendasTela);
            string escolha;
            do
            {
                Console.WriteLine("Seja bem vindo o que voce Deseja: \n \n " +
                    " 1 - Comprar \n " +
                    " 2 - Relatorio do Estoque \n " +
                    " 3 - Relatorio das vendas \n " +
                    " 0 - Sair Do Programa"
                    );
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.Clear();
                        TelaView.VendaView();
                        break;
                    case "2":
                        Console.Clear();
                        TelaView.RelatorioEstoqueView();
                        break;
                    case "3":
                        Console.Clear();
                        TelaView.RelatorioVendasView();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Valor invalido");
                        TelaInicialEstatica();
                        break;


                }


            }
            while (escolha != "0");
        }
    }
}
