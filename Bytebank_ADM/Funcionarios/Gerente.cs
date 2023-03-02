using Bytebank_ADM.SistemaInterno;
using Bytebank_ADM.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Gerente : FuncionarioAutenticavel, IBonificacao
    {
        public Gerente(string cpf) : base(cpf, 4000) { }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
