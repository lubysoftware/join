using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioPOO.Interfaces;

namespace DesafioPOO
{
    public class View
    {
        private readonly IEstoque estoque;
        private readonly IVendas vendas;
        List<Produto> EstoqueProdutos = new List<Produto>();
        Vendas VendasProdutos = new Vendas();



        public View(IEstoque estoque, IVendas vendas )
        {
            this.estoque = estoque;
            this.vendas = vendas;

            EstoqueProdutos.Add(new Produto { Nome = "Coca-Cola", Quantidade = 5, Preco = 3.50 });
            EstoqueProdutos.Add(new Produto { Nome = "Fanta", Quantidade = 10, Preco = 3.00 });
            EstoqueProdutos.Add(new Produto { Nome = "Antartica", Quantidade = 10, Preco = 3.20 });

            VendasProdutos.QuantidadeDeVendas = 0;
            VendasProdutos.ValorTotal = 0;
            
        }
            


        internal void Tela()
        {

           
            string escolha;
            do
            {
                Console.WriteLine("Seja bem vindo o que voce Deseja: \n" +
                    "1 - Comprar \n" +
                    "2 - Relatorio do Estoque \n" +
                    "3 - Relatorio das vendas \n " +
                    "0 - Sair Do Programa"
                    );
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.Clear();
                        VendaView();
                        break;
                    case "2":
                        Console.Clear();
                        RelatorioEstoqueView();
                        break;
                    case "3":
                        Console.Clear();
                        RelatorioVendasView();
                        break;
                    case "0":
                         Environment.Exit(0);
                        break;
                     default:
                        Console.Clear();
                        Console.WriteLine("Valor invalido");
                        Tela();
                        break;


                }


            }
            while(escolha != "0") ;
        }

        internal async void VendaView()
        {
            double valoritem = 0;


            Console.WriteLine("O que deseja comprar: \n \n" +
                "1- Coca-cola RS3,50 \n" +
                "2- Fanta RS3,00 \n" + 
                "3- Antartica RS3,20 \n" +
                "0-Voltar"
                );
            string escolhavenda = Console.ReadLine();
            if(escolhavenda == "0")
            {
                Console.Clear();
                Tela();
            }
            
            Console.WriteLine("Digite o valor do Seu Dinheiro: ");
            string valor = Console.ReadLine();

            double valortratado = Convert.ToDouble(valor);

            if (escolhavenda == "1")
            {
                 
                foreach (var item in EstoqueProdutos)
                {
                    if(item.Nome == "Coca-Cola")
                    {
                     
                        if (valortratado < item.Preco)
                        {
                            Console.Clear();
                            Console.WriteLine("Digite um valor igual ou superior o valor do produto: \n falta " + (item.Preco - valortratado)+"\n");
                            VendaView();
                        }

                        if(item.Quantidade == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Produto esgotado!\n");
                            VendaView();
                        }

                        valoritem = item.Preco;
                        item.Quantidade--;
                    }
                }
              
            }
            else if(escolhavenda == "2")
            {
                
               
                foreach (var item in EstoqueProdutos)
                {

                    if (item.Nome == "Fanta")
                    {

                        if (valortratado < item.Preco)
                        {
                            Console.Clear();
                            Console.WriteLine("Digite um valor igual ou superior o valor do produto: \n falta " + (item.Preco - valortratado) + "\n");
                            VendaView();
                        }
                        if (item.Quantidade == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Produto esgotado! \n");
                            VendaView();
                        }


                        valoritem = item.Preco;
                        item.Quantidade--;
                    }  

                }
               



            }
           else if(escolhavenda == "3")
            {
                foreach (var item in EstoqueProdutos)
                {
                    if (item.Nome == "Antartica")
                    {
                        if (valortratado < item.Preco)
                        {
                            Console.Clear();
                            Console.WriteLine("Digite um valor igual ou superior o valor do produto: \n falta " + (item.Preco - valortratado) + "\n");
                            VendaView();
                        }

                        if (item.Quantidade == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Produto esgotado! \n");
                            VendaView();
                        }

                        valoritem = item.Preco;
                        item.Quantidade--;
                    }
                }
               
            }
            else if(escolhavenda == "0")
            {
                Console.Clear();
                Tela();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Valor Inválido, por favor escolher uma das opções! \n");
                VendaView();
            }

            var verificarVenda = VendasProdutos.EfetuarVenda(valortratado, valoritem);
            if (verificarVenda)
            {
                Console.Clear();
                Console.WriteLine("<--Obrigado por Comprar Conosco!--> \n");
                Console.WriteLine("1 - Voltar \n" + "0 - Sair Programa");
                string escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    Console.Clear();
                    Tela();
                }
                if (escolha == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    RelatorioEstoqueView();
                }
            }
        }

        internal void RelatorioEstoqueView()
        {
            Console.Clear();
            Console.WriteLine("Relatorio De Estoque \n");
            foreach(var item in EstoqueProdutos)
            {
                Console.WriteLine($"Nome: {item.Nome} \n Quantidade: {item.Quantidade} \n Preco:{item.Preco} \n");
            }
            Console.WriteLine("1 - Voltar \n" + "0 - Sair Programa");
            string escolha = Console.ReadLine();
            if(escolha == "1")
            {
                Console.Clear();
                Tela();
            }
            if(escolha == "0")
            {
                Environment.Exit(0);
            }
            else
            {
                RelatorioEstoqueView();
            }
        }

        internal void RelatorioVendasView()
        {
            Console.Clear();
            double valortotal = VendasProdutos.GetTotalVendas();
            int quantidadeDeVenda = VendasProdutos.GetQuantidadeDeVendas();

            Console.WriteLine($"Relatorio De Vendas \n Valor Total De vendas: {valortotal} \n QuantidadeDeVendas: {quantidadeDeVenda}\n");
            Console.WriteLine("1 - Voltar \n" + "0 - Sair Programa");
            string escolha = Console.ReadLine();
            if (escolha == "1")
            {
                Console.Clear();
                Tela();
            }
            if (escolha == "0")
            {
                Environment.Exit(0);
            }
            else
            {
                RelatorioVendasView();
            }

        }



        



    }
}
