using Bytebank_ADM.SistemaInterno;
using Bytebank_ADM.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel, IBonificacao
    {

        public Diretor(string cpf) : base(cpf, 5000) { }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
    }
}
