using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Retangulo//classe onde foi declarada as variaveis
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }
        public double Area()//método para calcular a área
        {
            return Largura * Altura;
        }
        public double Perimetro()//método para calcular o perimetro
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()//método para calcular a diagonal
        {
            return (double)Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public override string ToString()//guarda e retorna os dados que serão mostrados no final da execução do programa
        {
            return " AREA: "
                +Area()
                +"\n PERIMETRO: "
                +Perimetro()
                +"\n DIAGONAL: "
                +Diagonal();
        }
    }
}
