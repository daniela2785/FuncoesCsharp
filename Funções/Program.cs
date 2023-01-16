using System;

namespace Funções{
    class Program
    {
        static void Main(string[] args)
        {
            GerarPreco(-60);//aqui no parenteses temos que colocar o valor do parametro
            GerarPreco(-95);

            Console.ReadLine();
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
            
    }
}