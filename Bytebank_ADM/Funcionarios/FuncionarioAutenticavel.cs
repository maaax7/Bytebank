using Bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public string Login { get; set; }

        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public bool Autenticar(string login, string senha)
        {
            return this.Login == login && this.Senha == senha;
        }
    }
}
