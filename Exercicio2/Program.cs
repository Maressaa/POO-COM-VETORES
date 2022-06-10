using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários deseja digitar? ");//pergunta a quantidade de funcionarios
            int qtd_f = int.Parse(Console.ReadLine());//guarda a quantidade de funcionarios

            Dados[] dados = new Dados[qtd_f];//puxa a classe

            for (int i = 0; i < qtd_f; i++)
            {
                Console.WriteLine("NOME: ");//pergunta o nome do funcionario
                String nome = Console.ReadLine();//guarda o nome do funcionario
                Console.WriteLine("SALÁRIO BRUTO: ");//pergunta o salario bruto
                double salariob = double.Parse(Console.ReadLine());//guarda o salario bruto
                Console.WriteLine("IMPOSTO: ");//pergunta quanto é o imposto
                double imposto = double.Parse(Console.ReadLine());//guarda o valor do imposto

                dados[i] = new Dados(nome, salariob, imposto);            
            
                Console.WriteLine(dados[i]);//mostra os dados
                Console.WriteLine();
                Console.WriteLine("Quanto vai ser o aumento em % sobre o salário bruto: ");//pergunta a % do aumento
                dados[i].AumentarSlr(double.Parse(Console.ReadLine()));//guarda a % do aumento
                Console.WriteLine(dados[i]);//mostra os dados atualizados
            }
        }
    }
}