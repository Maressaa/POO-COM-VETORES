using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Retangulos vão ser digitados? ");//Pergunta quantos triangulos serão digitados 
            int qtd_retangulos = int.Parse(Console.ReadLine());//pega o número de triangulos que serão calculados

            Retangulo[] retangulo = new Retangulo[qtd_retangulos];//puxa a classe

            for (int i = 0; i < qtd_retangulos; i++)
            {
                Console.WriteLine("Digite a Altura e a Largura do Retangulo " + (i + 1) + ":");//pergunta altura e largura do retangulo
                double altura = double.Parse(Console.ReadLine());//guarda o valor da altura
                double largura = double.Parse(Console.ReadLine());//guarda o valor da largura

                retangulo[i] = new Retangulo(altura, largura);//guarda os valores na classe retangulo
            }
            for (int i = 0; i < qtd_retangulos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("**** Dados do " + (i + 1) + " retangulo ****");
                Console.WriteLine(retangulo[i]);//mostra os dados: área, perimetro e diagonal
            }
        }
    }
}