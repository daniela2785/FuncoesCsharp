using System;

namespace Funções{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            GerarPreco(-60);//aqui no parenteses temos que colocar o valor do parametro
            GerarPreco(-95);
            */

            /*retorno de função
            string valor = Console.ReadLine();// a função ReadLine executou, capturou a entrada do usuario
            Console.WriteLine(valor); //capturou a entrada do usuario e retornou o valor que o usuario digitou para a variavel valor
            Console.ReadLine();//e depois exibiu a mensagem valor 
            */

            int soma1 = Somar(1, 2, 3);
            int soma2 = Somar(20, 30, 40);
            int soma3 = Somar(100, 300, 400);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);

            }
        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é muito bom");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Seja bem vindo!!");
            Console.WriteLine("Guia do programador.");
        }

        static void GerarPreco(int preco) // o que está dentro dos parenteses são paramentros, bem semelhante a variaveis.
        {    //lembrando que esse paramentro só pode ser utilizado dentro da função 

            int precoAbs = Math.Abs(preco); //função para deixar todos os valores positivos
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
        }
        //tipos de retorno: void, string, bool, float, int...
        //o tipo de retorno sempre fica antes do nome da função
        // quando define um tipo de retorno na função, é obrigatorio retornar algo dentro da sua funçao
        //quando coloca void não é obrigatorio retornar nada
        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c; 
            return resultadoFinal;
        }
    }
}