using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicaProgramacao
{
    public class Resolucao
    {
        //1.1
        //Implemente a função abaixo para calcular fatorial de um número
        public static int CalcularFatorial(int numero)
        {
            int resultado = numero;

            for (int i = numero; i > 1; i--)
            {

                resultado *= (i - 1);


            }

            return resultado;

        }


        //1.2
        //Implemente a função abaixo que calcula o valor total do prêmio somando fator do tipo do prêmio conforme
        public static int CalcularPremio(int ValorInicial, string TipoDoPremio, int? MultiplicacaoProprio)
        {
            //Validação dos Valores inseridos
            if (TipoDoPremio == null || MultiplicacaoProprio < 0 || ValorInicial < 0)
            {
                Console.Write("Valores Invalidos");
            }

            //Transformando o TipoDoPremio no seu respectivo valores
            double ValorTipoDoPremio = 0;
            switch (TipoDoPremio.ToLower())
            {
                case "basic":
                    ValorTipoDoPremio = 1;
                    break;

                case "vip":
                    ValorTipoDoPremio = 1.2;
                    break;

                case "premium":
                    ValorTipoDoPremio = 1.5;
                    break;

                case "deluxe":
                    ValorTipoDoPremio = 1.8;
                    break;
                case "special":
                    ValorTipoDoPremio = 2;
                    break;

                default:
                    Console.WriteLine("Valor Inválido, Escolha um tipo de Premio: basci /n vip /n premium / deluxe / special");
                    break;


            }

            int? MultiplicacaoNullValiable = 0;
            if (MultiplicacaoProprio == null)
            {
                MultiplicacaoNullValiable = 1;
            }
            else
            {
                MultiplicacaoNullValiable = MultiplicacaoProprio;
            }


            return (int)(ValorInicial * ValorTipoDoPremio * MultiplicacaoNullValiable);

        }


        //1.3
        //Implemente a função abaixo para contar quantos números primos existem até o número informado
        internal static bool ItsPrimo(int numero)
        {
            for (int j = 2; j < numero; j++)
            {
                if (numero % j == 0)
                    return false;
            }
            return true;

        }

        public static int CalcularPrimo(int numero)
        {
            int contator = 0;
            for (int i = 2; i <= numero; i++)
            {
                if (ItsPrimo(i))
                {
                    Console.WriteLine("O numero Primo: " + i);
                    contator++;
                }


            }

            Console.Write("Total de Numeros Primos:" + contator);
            return contator;

        }

        //1.4
        //Implemente a função abaixo que conta e calcula a quantidade de vogais dentro de uma string
        public static int CalcularVogais(string nome)
        {
            int contator = 0;
            char[] NomeChar = nome.ToLower().ToCharArray();

            string Vogais = "aeiou";
            char[] VogaisChar = Vogais.ToCharArray();

            var intersect = NomeChar.Intersect(VogaisChar);

            foreach (var item in intersect)
            {
                Console.WriteLine(item);
                contator++;

            }

            Console.WriteLine("Total De vogais:" + contator);
            return contator;
        }

        //1.5
        //Implemente a função abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado.
        public static string CalcularDesconto(string preco, string desconto)
        {

            string precotratado = Regex.Replace(preco, @"[$%a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ\.@-]", string.Empty);
            string descontotratado = Regex.Replace(desconto, @"[$%a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ.@-]", string.Empty);


            decimal PrecoDecimal = Decimal.Parse(precotratado);

            decimal DescontoDecimal = Decimal.Parse(descontotratado);

            decimal Resultado = ((DescontoDecimal / 100) * PrecoDecimal) + PrecoDecimal;

            string ResultadoTratado = "R$" + Resultado.ToString();

            return ResultadoTratado;

        }

        //1.6
        //Implemente a função abaixo que obtém duas string de datas e calcula a diferença de dias entre elas
        public static int CalcularDiasEntreDatas(string data1, string data2)
        {
            char[] data1Array = data1.ToCharArray();
            char[] data2Array = data2.ToCharArray();

            //Validacao De Datas
            if (data1Array.Length < data2Array.Length || data1Array.Length > data2Array.Length)
            {
                Console.WriteLine("Valor Inválido: Porfavor colocar uma data conforme exemplo 09022021 DDMMYYYY ");
            }

            //Pegando as datas no array
            string DiaData1 = data1Array[0].ToString() + data1Array[1].ToString();
            string DiaData2 = data2Array[0].ToString() + data2Array[1].ToString();

            string MesData1 = data1Array[2].ToString() + data1Array[3].ToString();
            string MesData2 = data2Array[2].ToString() + data2Array[3].ToString();

            string AnoData1 = data1Array[4].ToString() + data1Array[5].ToString() + data1Array[6].ToString() + data1Array[7].ToString();
            string AnoData2 = data2Array[4].ToString() + data2Array[5].ToString() + data2Array[6].ToString() + data2Array[7].ToString();

            //Convertendo os valores para int
            int _DiaData1 = int.Parse(DiaData1);
            int _DiaData2 = int.Parse(DiaData2);

            int _MesData1 = int.Parse(MesData1);
            int _MesData2 = int.Parse(MesData2);

            int _AnoData1 = int.Parse(AnoData1);
            int _AnoData2 = int.Parse(AnoData2);

            //Trasnformando os valores em tipo datetime
            DateTime Data1Tratado = new DateTime(_AnoData1, _MesData1, _DiaData1);
            DateTime Data2Tratado = new DateTime(_AnoData2, _MesData2, _DiaData2);

            int Resultado = (int)Data1Tratado.Subtract(Data2Tratado).TotalDays;

            //Realizando o tratamento na saida caso de numero negativo tirar o - 

            string TratamentoResultado = Regex.Replace(Resultado.ToString(), @"[-]", string.Empty);

            int ResultadoTratado = int.Parse(TratamentoResultado);

            return ResultadoTratado;








        }

        //1.7
        //Implemente a função abaixo que retorna um novo vetor com todos elementos pares do vetor informado
        public static int[] ObterElementosPares(int[] vetor)
        {
            int[] Resultado = new int[vetor.Length];
            int indicecontator = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Resultado[indicecontator] = vetor[i];
                    indicecontator++;

                }
            }

            return Resultado;
        }

        //1.8
        //Implemente a função abaixo que deve buscar um ou mais elementos no vetor que contém o valor ou parte do valor informado na busca.
        public static string[] BuscarPessoa(string[] vetor, string pessoa)
        {
            string[] Resultado = Array.FindAll(vetor, x => x.Contains(pessoa));

            return Resultado;


        }

        //1.9
        //Implemente a função abaixo que obtém uma string com números separados por vírgula e transforma em um array de array de inteiros com no máximo dois elementos.
        public static int[,] TransformarEmMatriz(string vetor)
        {
            string caracterempty = string.Empty;
            string VetorSemVirgula = vetor.Replace(",", caracterempty);

            char[] VetorArraySemVirgula = VetorSemVirgula.ToCharArray();

            int[] _VetorArraySemVirgula = new int[VetorArraySemVirgula.Length];
            int Contator = 0;

            for (int i = 0; i < VetorArraySemVirgula.Length; i++)
            {
                _VetorArraySemVirgula[Contator] = int.Parse(VetorArraySemVirgula[i].ToString());
                Contator++;
            }


            int[,] Resultado = new int[(_VetorArraySemVirgula.Length / 2) + 1, 2];
            //ArrayList Resultado = new Array

            int ContatorIndice1 = 0;
            int ContatorIndice2 = 1;
            for (int i = 0; i < Resultado.Length; i++)
            {
                if(ContatorIndice1 < Resultado.Length && ContatorIndice2 < Resultado.Length)
                {
                    try {
                        Resultado[i, 0] = _VetorArraySemVirgula[ContatorIndice1];
                        Resultado[i, 1] = _VetorArraySemVirgula[ContatorIndice2];

                        ContatorIndice1 = ContatorIndice1 + 2;
                        ContatorIndice2 = ContatorIndice2 + 2;
                    }
                    catch
                    {
                        Console.WriteLine(Resultado);
                    }
                  

                }



            }
           
            return Resultado;



        }

        // 1.10
        // Implemente a função abaixo que compara dois vetores e cria um novo vetor com os elementos faltantes de ambos.
        public static int[] ObterElementosFaltantes(int[] vetor1, int[] vetor2)
        {
            ArrayList Resultado = new ArrayList();

            for (int i = 0; i < vetor1.Length; i++)
            {
                if ((Array.Exists(vetor2, x => x == vetor1[i]) == false))
                {
                    Resultado.Add(vetor1[i]);
                }
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                if ((Array.Exists(vetor1, x => x == vetor2[i]) == false))
                {
                    Resultado.Add(vetor2[i]);
                }
            }



            int[] ResultadoTratado = (int[])Resultado.ToArray(typeof(int));

            return ResultadoTratado;


        }
    }
}
