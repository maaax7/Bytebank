using Bytebank_ADM.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario, IBonificacao
    {
        public Designer(string cpf) : base(cpf, 3000) { }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public double GetBonificacao()
        {
            return this.Salario * 0.17;
        }
    }
}
