using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaProgramacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao.Tests
{
    [TestClass()]
    public class ResolucaoTests
    {
        [TestMethod()]
        public void CalcularFatorialTest()
        {
            int resultado = 5;
            int esperado = 120;

            for (int i = 5; i > 1; i--)
            {

                resultado *= (i - 1);


            }



            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void CalcularPremioTest()
        {
            int resultado = Resolucao.CalcularPremio(100, "vip", null);

            int esperado = 120;

            Assert.AreEqual(esperado, resultado);

        }

        [TestMethod()]
        public void CalcularPrimoTest()
        {
            int esperado = 4;
            int resultado = Resolucao.CalcularPrimo(10);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void CalcularVogaisTest()
        {
            int esperado = 2;
            int resultado = Resolucao.CalcularVogais("Malthus");

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void CalcularDescontoTest()
        {
            string esperado = "R$120,0";

            string resultado = Resolucao.CalcularDesconto("R$100", "20%");

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void CalcularDiasEntreDatasTest()
        {
            int esperado = 15;
            int resultado = Resolucao.CalcularDiasEntreDatas("25122020", "10122020");

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void ObterElementosParesTest()
        {
            int[] esperado = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] resultado = Resolucao.ObterElementosPares(esperado);


            bool resultadobolean = false;

            for (int i = 0; i < esperado.Length; i++)
            {
                if (resultado != null)
                {
                    if ((resultado[i] % 2) == 0)
                    {
                        resultadobolean = true;
                    }
                }
            }

            Assert.IsTrue(resultadobolean);

        }

        [TestMethod()]
        public void BuscarPessoaTest()
        {
            string[] vetor = new string[] {
                    "John Doe",
                    "Jane Doe",
                    "Alice Jones",
                    "Bobby Louis",
                    "Lisa Romero"
                };
            string[] Resultado = Resolucao.BuscarPessoa(vetor, "Jones");

            string[] esperado = new string[] { "Alice Jones" };

            Assert.AreEqual(esperado[0], Resultado[0]);
        }

        [TestMethod()]
        public void TransformarEmMatrizTest()
        {
            int[,] vetoresperado = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            int[,] vetorresultado = Resolucao.TransformarEmMatriz("1,2,3,4,5,6");

            Assert.AreEqual(vetoresperado[0,0], vetorresultado[0,0]);
        }

        [TestMethod()]
        public void ObterElementosFaltantesTest()
        {
            int[] vetor1 = new int[] { 1, 2, 3, 4, 5 };
            int[] vetor2 = new int[] { 1, 2, 5 };

            int[] resultado = Resolucao.ObterElementosFaltantes(vetor1, vetor2);

            int[] esperado = new int[] { 3, 4 };

            Assert.AreEqual(esperado[0], resultado[0]);
        }
    }
}