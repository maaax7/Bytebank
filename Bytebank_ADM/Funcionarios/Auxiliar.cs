using Bytebank_ADM.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario, IBonificacao
    {
        public Auxiliar(string cpf) : base(cpf, 2000) { }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }

        public double GetBonificacao()
        {
            return this.Salario * 0.20;
        }
    }
}
