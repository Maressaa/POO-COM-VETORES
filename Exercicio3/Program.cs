using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("As notas de quantos alunos voce quer ? ");//pergunta quantos alunos serão adicionados ao programa
            int qtdAlunos = int.Parse(Console.ReadLine());//variavel que guarda a quantidade de alunos
            Aluno[] aluno = new Aluno[qtdAlunos];//puxa a classe

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine(" ***DADOS DO " + (i + 1) + "° ALUNO ***");
                Console.WriteLine("Digite o nome do aluno : ");//pergunta o nome
                string nome = Console.ReadLine(); //guarda o nome
                Console.WriteLine("Digite a nota do 1º: (limite maximo da nota é 30)");//pede para digitar a 1º nota
                double nota1 = double.Parse(Console.ReadLine());//guarda a 1ºnota
                while (nota1 > 30)
                {
                    if (nota1 > 30)
                    {
                        Console.WriteLine("Nota inválida, nota máxima é 30, digite novamente! ");//pede para digitar a 1º nota caso tenha digitado errado
                        Console.WriteLine("Digite a nota do 1º: (limite maximo da nota é 30)");
                        nota1 = double.Parse(Console.ReadLine());//guarda a 1ºnota
                    }
                }
                Console.WriteLine("Digite a nota do 2º: (limite maximo da nota é 35)");//pede para digitar a 2º nota
                double nota2 = double.Parse(Console.ReadLine()); //guarda a 2ºnota
                while (nota2 > 35)
                {
                    if (nota2 > 35)
                    {
                        Console.WriteLine("Nota inválida, nota máxima é 35, digite novamente! ");//pede para digitar a 2º nota caso tenha digitado errado
                        Console.WriteLine("Digite a nota do 2º: (limite maximo da nota é 35)");
                        nota2 = double.Parse(Console.ReadLine());//guarda a 2ºnota
                    }
                }
                Console.WriteLine("Digite a nota do 3º: (limite maximo da nota é 35)");//pede para digitar a 3º nota
                double nota3 = double.Parse(Console.ReadLine());//guarda a 3ºnota
                while (nota3 > 35)
                {
                    if (nota3 > 35)
                    {
                        Console.WriteLine("Nota inválida, nota máxima é 35, digite novamente! ");//pede para digitar a 3º nota caso tenha digitado errado
                        Console.WriteLine("Digite a nota do 3º: (limite maximo da nota é 35)");
                        nota3 = double.Parse(Console.ReadLine());//guarda a 3ºnota
                    }
                }
                Console.WriteLine();
                Console.WriteLine(); aluno[i] = new Aluno(nome, nota1, nota2, nota3);
            }
            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine();
                Console.WriteLine(" *** NOTA FINAL DO " + (i + 1) + "° ALUNO ***");
                Console.WriteLine(); Console.WriteLine();//mostra se o auno foi aprovado ou reprovado e suas respectivas notas
                Console.WriteLine(aluno[i]);
                Console.WriteLine();
            }
        }
    }
}

