using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Dados//classe onde foi declarada as variaveis
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string DataNasc { get; set; }
        public string Email { get; set; }


        public Dados(string nome, string cpf, string telefone, string endereco, string datanasc, string email)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Endereco = endereco;
            DataNasc = datanasc;
            Email = email;
        }
        public override string ToString()//método que guarda e mostra os dados informados
        {
            return "O quarto foi alugado para "
                + Nome.ToUpper()
                + ",\n cujo o CPF é: "
                + CPF
                + ",\n TELEFONE: "
                + Telefone
                + ",\n ENDEREÇO: "
                + Endereco
                + ",\n DATA DE NASCIMENTO: "
                + DataNasc
                + ",\n EMAIL: "
                + Email;
        }

    }
    class Quartos//classe onde foi declarada as variaveis
    {
        public float Periodo { get; set; }
        public float Valor { get; set; }


        public Quartos(float periodo, float valor)
        {
            Periodo = periodo;
            Valor = valor;
        }

        public double ValorTotal()//método onde calcula o valor pelo periodo determinado
        {
            return Periodo * Valor;
        }
        public override string ToString()//método que guarda e mostra os dados informados
        {
            return " VALOR: "
                + Valor.ToString("C")
                + ",\n VALOR TOTAL: "
                + ValorTotal().ToString("C");

        }

    }

}
