using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.SistemaInterno
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }
        public string Login { get; set; }
        bool Autenticar(string login, string senha);
    }
}
