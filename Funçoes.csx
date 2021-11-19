using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program{

    static int CalcularFatorial(int input){
        int res = 1;
        for(int i = 1; i <= input; i++){
            res *= i;
        }
        return res;
    }

    static float CalcularPremio(int price, string type, float? fator){
        float res;

        if(price <= 0){
            Console.WriteLine("Valor invalido de premio, verique se não está ganhando envez de dever!");
            return -1;
        }

        if(fator != null){
            res = (float) fator;
            if(res <= 0){
                Console.WriteLine("Fator invalido, verique se o seu fator de multiplicação!");
                return -1;
            }
        }else{
            switch(type){
                case "basic":
                    res = 1;
                    break;
                case "vip":
                    res = 1.2f;
                    break;
                case "premium":
                    res = 1.5f;
                    break;
                case "deluxe":
                    res = 1.8f;
                    break;
                case "special":
                    res = 2;
                    break;
                default:
                    Console.WriteLine("Tipo ou fator do premio não encontrado. Verifique novamente!");
                    return -1;
            }
        }
        return res *= price;
    }

    static int ContarNumerosPrimos(int input){
        int res = 0;
        for(int i = 2; i <= input; i++){
            if(i <= 3){
                res++;
            }else{
                for(int j = 2; j < i; j++){
                    if(i%j == 0){
                        res--;
                        break;
                    }
                }
                res++;
            }
        }
        return res;
    }

    static int CalcularVogais(string input){
        int res = 0;
        

        input = input.Replace(" ", null);
        char[] aux = input.ToCharArray();

        foreach(char aux2 in aux){
            if(aux2 == 'a'| aux2 == 'e'| aux2 == 'i'| aux2 == 'o'| aux2 == 'u'){
                res++;
            }
        }
        return res;
    }

    static string CalcularValorComDescontoFormatado(string preco, string desc){
        preco = preco.Replace("R", null).Replace("$", null).Replace(" ", null).Replace(".", null).Replace(",", null);
        float aux = (float.Parse(preco))/100;
        desc = desc.Replace("%", null);
        float aux2 = float.Parse(desc)/100;

        aux -= (float) (aux*aux2);
        preco = String.Format("{0:C}",aux);
        return preco;
    }

    static int CalcularDiferencaData(string data1, string data2){
        int aux;

        data1 = data1.Insert(2,".").Insert(5,".");
        data2 = data2.Insert(2,".").Insert(5,".");
        string[] data11 = data1.Split('.'); 
        string[] data22 = data2.Split('.');

        aux = int.Parse(data22[0]) - int.Parse(data11[0]);

        aux += 30 * (int.Parse(data22[1]) - int.Parse(data11[1]));

        aux += 365 * (int.Parse(data22[2]) - int.Parse(data11[2]));
        
        return aux;
    }

    static int[] ObterElementosPares(int[] input){
        for(int i = 0; i < input.Length; i++){
            if(input[i] % 2 != 0){
                input[i] = 1;
            }
        }
        var aux = input.ToList();
        while(aux.Contains(1)){
            aux.Remove(1);
        }
        input = aux.ToArray();
        return input;
    }

    static string[] BuscarPessoa(string[] group, string input){
        List<string> aux = new List<string>();
        for(int i = 0; i < group.Length; i++){
            if(group[i].Contains(input)){
                aux.Add(group[i]);
            }
        }
        return aux.ToArray();
    }

    static int[,] TransformarEmMatriz(string input){

        if(input.Length % 2 != 0){
            input = input + ",-1";
        }
        string[] aux = input.Split(',');
        int [,] res = new int[aux.Length/2,2];

        for(int i = 0, k = 0; i < aux.Length / 2; i++){
            for(int j = 0; j < 2; j++){
                res[i,j] = int.Parse(aux[k]);
                k++;
            }
        }
        return res;
    }

    static int[] ObterElementosFaltantes(int[] input, int[] input2){
        var res = new List<int>();

        var aux1 = input.ToList();
        var aux2 = input2.ToList();

         for(int i = 0; i < input.Length; i++){
            if(aux2.Contains(input[i])){
                aux2.Remove(input[i]);
            }
         }

         for(int i = 0; i < input2.Length; i++){
            if(aux1.Contains(input2[i])){
                aux1.Remove(input2[i]);
            }
         }
        foreach(int i in aux1){
            res.Add(i);
        }
        foreach(int i in aux2){
            res.Add(i);
        }

        return res.ToArray();
    }

    static void Main(){
        //1.1
        int fatorial = CalcularFatorial(5);
        Console.WriteLine("Resultado do fatorial: {0}",fatorial);

        //1.2
        float premio = CalcularPremio(100, "vip", null);
        Console.WriteLine("Resultado do premio: {0}", premio);

        premio = CalcularPremio(100, "basic", 3);
        Console.WriteLine("Resultado do premio: {0}", premio);

        //1.3
        int numeros_primos = ContarNumerosPrimos(10);
        Console.WriteLine("Resultado de quantos numeros primos: {0}", numeros_primos);

        //1.4
        int numeros_vogais = CalcularVogais("Luby Software");
        Console.WriteLine("Resultado de quantas vogais: {0}",numeros_vogais);

        //1.5
        string valor_formatado = CalcularValorComDescontoFormatado("R$ 6.800,00", "30%");
        Console.WriteLine("Resultado do valor formatado: {0}",valor_formatado);

        //1.6
        int diferença_data = CalcularDiferencaData("10122020", "25122020");
        Console.WriteLine("Resultado da diferença de data: {0}",diferença_data);

        //1.7
        int[] vetor = new int[] { 1,2,3,4,5 };
        int[] elementos_pares = ObterElementosPares(vetor);

        Console.Write("Resultado dos elementos pares: { ");
        foreach(int i in elementos_pares){
            Console.Write("{0}, ", i );
        }
        Console.WriteLine("}");

        //1.8
        string[] vetor2 = new string[] {
            "John Doe",
            "Jane Doe",
            "Alice Jones",
            "Bobby Louis",
            "Lisa Romero"
        };

        string[] grupo_pessoas = BuscarPessoa(vetor2, "Doe");
        Console.Write("Resultado da busca de pessoas: { ");
        foreach(string i in grupo_pessoas){
            Console.Write("{0}, ", i);
        }
        Console.WriteLine("}");

        //1.9
        int[,] matriz = TransformarEmMatriz("1,2,3,4,5,6");
        Console.WriteLine("Resultado da transformaçao em matriz :");
        for(int i = 0; i < matriz.GetLength(0); i++){
            for(int j = 0; j < matriz.GetLength(1); j++){
                if(matriz[i,j] != -1){
                    Console.Write("{0} ",matriz[i,j]);
                }else{
                    Console.Write("null ");
                }
            }
            Console.WriteLine("");
        }

        //1.10
        int[] vetor3 = new int[] { 1,2,3,4,5 };
        int[] vetor4 = new int[] { 1,2,5 };
        int[] elementos_faltando = ObterElementosFaltantes(vetor3, vetor4);

        Console.Write("Resultado dos elementos faltantes:{ ");
        foreach(int i in elementos_faltando){
            Console.Write("{0}, ",i);
        }
        Console.Write("}");
    }
}