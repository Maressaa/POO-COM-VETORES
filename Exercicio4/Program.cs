using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos estão diponiveis?");//pergunta quantos quartos estão disponiveis
            int qtd_quartos = int.Parse(Console.ReadLine());//guarda a quantidade de quartos disponiveis

            Dados[] dados = new Dados[qtd_quartos];//puxa a classe e define o tamanho do vetor
            Quartos[] quartos = new Quartos[qtd_quartos];//puxa a classe e define o tamanho do vetor

            for (int i = 0; i < qtd_quartos; i++)
            {
                Console.WriteLine("****ALUGUEL MENSAL DE QUARTO*****");//pergunta os dados do hospede
                Console.WriteLine();
                Console.Write("NOME: ");
                String nome = Console.ReadLine();
                Console.Write("CPF: ");
                String cpf = Console.ReadLine();
                Console.Write("TELEFONE: ");
                String telefone = Console.ReadLine();
                Console.Write("ENDEREÇO: ");
                String endereco = Console.ReadLine();
                Console.Write("DATA DE NASCIMENTO: ");
                String datanasc = Console.ReadLine();
                Console.Write("EMAIL: ");
                String email = Console.ReadLine();


                Console.Write("Por quantos meses deseja alugar nosso quarto? ");
                float periodo = float.Parse(Console.ReadLine());//guarda o periodo 
                Console.WriteLine("Qual o valor do quarto? ");//pergunta o valor do quarto
                float valor = float.Parse(Console.ReadLine());//guarda o valor do quarto

                Console.WriteLine(); Console.WriteLine();

                Console.WriteLine();

                quartos[i] = new Quartos(periodo, valor);
                dados[i] = new Dados(nome, endereco, cpf, telefone, datanasc, email);
            }
            for (int i = 0; i < qtd_quartos; i++)
            {
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("***RELATÓRIO DO HÓSPEDE" + (i + 1) + "***");//mostra o relatorio do hospede e valor por mês e pelo periodo
                Console.WriteLine();
                Console.WriteLine(dados[i]);
                Console.WriteLine(quartos[i]);
                Console.WriteLine();
            }
        }
    }
}