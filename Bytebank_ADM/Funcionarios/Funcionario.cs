using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            TotalDeFuncionarios++;
            this.Cpf = cpf;
            this.Salario = salario;
        }

        public abstract void AumentarSalario();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Nome: {this.Nome}");
            sb.AppendLine($"Salario Atual: {this.Salario}");
            return sb.ToString();
        }
    }
}
