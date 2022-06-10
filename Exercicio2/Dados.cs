using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Dados//classe onde foi declarada as variaveis
    {
        public string Nome { get; set; }
        public double SalarioB { get; set; }
        public double Imposto { get; set; }

        public Dados(string nome, double salariob, double imposto)
        {
            Nome = nome;
            SalarioB = salariob;
            Imposto = imposto;
        }
        public double SalarioL()//método que calcula o salario liquido
        {
            return SalarioB - Imposto;
        }
        public void AumentarSlr(double aumento)//método sem retorno que altera o salario
        {
            SalarioB = SalarioB + (SalarioB * aumento / 100);
        }
        public override string ToString()//método que retorna os dados no final do programa
        {
            return "Funcionário: "
                +Nome.ToUpper()
                +",\n R$ "
                +SalarioL().ToString("F2");
        }
    }
}
